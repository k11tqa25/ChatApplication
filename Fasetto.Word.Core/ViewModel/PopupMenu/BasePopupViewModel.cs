namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for any popup menu
    /// </summary>
    public class BasePopupViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The background color of the bubble in ARGB value
        /// </summary>
        public string BubbleBackground { get; set; }

        /// <summary>
        /// The alignmnet of the bubble arrow
        /// </summary>
        public ElementHorizontalAlignment ArrorwAlignment { get; set; }

        /// <summary>
        /// The content inside of this popup menu
        /// </summary>
        public BaseViewModel Content { get; set; }

        #endregion

        #region Constructor

        public BasePopupViewModel()
        {
            // Set default values
            //TODO: Move colors into Core and make use of it here
            BubbleBackground = "ffffff";
            ArrorwAlignment = ElementHorizontalAlignment.Left;
        }

        #endregion
    }
}
