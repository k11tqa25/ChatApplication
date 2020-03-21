using Fasetto.Word.Core;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// The View Model for the custom flat window
    /// </summary>
    public class DialogViewModel : WindowViewModel
    {
        #region Public Properties

        /// <summary>
        /// The title of thie dialog window
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The content to host inside the dialog
        /// </summary>
        public Control Content { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public DialogViewModel(Window window): base(window)
        {
            // Make minimum size smaller
            WindowMinimumHeight = 100;
            WindowMinimumWidth = 250;

            // Make title bar smaller
            TitleHeight = 30;

        }
        #endregion

    }
}
