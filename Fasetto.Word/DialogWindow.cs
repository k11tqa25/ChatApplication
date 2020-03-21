using System.Windows;

namespace Fasetto.Word
{

    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        #region Private Member

        /// <summary>
        /// The view model for this window
        /// </summary>
        private DialogViewModel mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The view model for this window
        /// </summary>
        public DialogViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                // Set the view model
                mViewModel = value;

                // Update data context
                DataContext = mViewModel;
            }
        }


        #endregion

        #region Constructor

        public DialogWindow()
        {
            InitializeComponent();

        }

        #endregion
    }
}
