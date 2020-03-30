using System;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The settings state as a view model
    /// </summary>
    public class SettingsViewModel: BaseViewModel
    {

        #region Public Properties

        /// <summary>
        /// The current users name
        /// </summary>
        public TextEntryViewModel Name { get; set; }

        /// <summary>
        /// The current users name
        /// </summary>
        public TextEntryViewModel Username { get; set; }

        /// <summary>
        /// The current users password
        /// </summary>
        public TextEntryViewModel Password { get; set; }

        /// <summary>
        /// The current users email
        /// </summary>
        public TextEntryViewModel Email { get; set; }

        #endregion

        #region Public Command

        /// <summary>
        /// The command to open the settings menu
        /// </summary>
        public ICommand OpenCommand { get; set; }


        /// <summary>
        /// The command to close the settings menu
        /// </summary>
        public ICommand CloseCommand { get; set; }

        #endregion

        #region Constructor

        public SettingsViewModel()
        {
            OpenCommand = new RelayCommand(Open);
            CloseCommand = new RelayCommand(Close);
        }


        #endregion
        
        /// <summary>
        /// Opens the settings menu
        /// </summary>
        private void Open()
        {
            // open the settings window
            IoC.Application.SettingsWindowVisible = true;
        }

        /// <summary>
        /// Closes the settings menu
        /// </summary>
        private void Close()
        {
            // Close the settings window
            IoC.Application.SettingsWindowVisible = false;
        }

    }
}
