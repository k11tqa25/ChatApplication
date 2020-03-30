﻿using System.Windows.Controls;
using System.Windows;
using System.Threading.Tasks;
using Fasetto.Word.Core;
using System.ComponentModel;

namespace Fasetto.Word
{
    /// <summary>
    /// The base page for all pages to gain base functionality
    /// </summary>
    public class BasePage : UserControl
    {
        #region Public Properties

        /// <summary>
        /// The animation to play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation to play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.4f;

        /// <summary>
        /// A flag to indicate if this page should animate out on load.
        /// Useful for when we are moving the page to another frame
        /// </summary>
        public bool ShouldAnimateOut { get; set; }

        #endregion

        #region Constructor

        public BasePage()
        {
            // Don't bother animating in design time
            if (DesignerProperties.GetIsInDesignMode(this))
                return;

            // If we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            // Listen out for the page loading
            this.Loaded += BasePage_LoadedAsync;
        }

        #endregion

        #region Animation Load / Unload

        /// <summary>
        /// Once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_LoadedAsync(object sender, System.Windows.RoutedEventArgs e)
        {
            // If we are setup to animate out on load
            if (ShouldAnimateOut)
                // Animate out the page
                await AnimateOutAsync();
            // Otherwise...
            else
                // Animate the page in
                await AnimateInAsync();
        }

        /// <summary>
        /// Animates the page in
        /// </summary>
        public async Task AnimateInAsync()
        {
            // Make sure we have something to do
            if (this.PageLoadAnimation == PageAnimation.None) 
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    // Start the animation
                    await this.SlideAndFadeInAsync(AnimationSlideInDirection.Right,false, SlideSeconds, size: (int)Application.Current.MainWindow.Width);

                    break;
            }

        }

        /// <summary>
        /// Animates the page out
        /// </summary>
        public async Task AnimateOutAsync()
        {
            // Make sure we have something to do
            if (this.PageUnloadAnimation == PageAnimation.None) return;

            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    // Start the animation
                    await this.SlideAndFadeOutAsync(AnimationSlideInDirection.Right, this.SlideSeconds);
                    break;
            }
        }
        #endregion

    }


    /// <summary>
    /// A base page with added ViewModel support
    /// </summary>
    public class BasePage<VM>: BasePage
        where VM: BaseViewModel, new()
    {

        #region Private Member
        /// <summary>
        /// The view model associated with this page
        /// </summary>
        private VM mViewModel;
        #endregion

        #region Public Properties

        /// <summary>
        /// The view model associated with this page
        /// </summary>
        public VM ViewModel {
            get => mViewModel;
            set
            {
                // If nothing has changed, then
                if (mViewModel == value)
                    return;

                // Update the value
                mViewModel = value;

                // Set the data context for this page
                this.DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor

        public BasePage(): base()
        {
            // Create a default view model
            this.ViewModel = new VM();
        }

        #endregion
    }
}
