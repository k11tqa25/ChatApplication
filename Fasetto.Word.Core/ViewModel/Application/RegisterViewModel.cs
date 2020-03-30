using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The View Model for a register screen
    /// </summary>
    public class RegisterViewModel: BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool RegisterIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register
        /// </summary>
        public ICommand RegisterCommand { get; set; }


        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            // Create commands
            RegisterCommand = new RelayParamatizedCommand(async (parameter) => await RegisterAsync(parameter));
            // Create commands
            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        /// <summary>
        /// Attempts to register a new user
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString" />passed in from the view for the users password.</param>
        /// <returns></returns>
        public async Task RegisterAsync(object parameter)
        {
            await RunCommand(() => this.RegisterIsRunning, async () =>
            {
                await Task.Delay(500);
            });

        }

        /// <summary>
        /// Takes the user to the login page
        /// </summary
        /// <returns></returns>
        public async Task LoginAsync()
        {
            // Go to login page
            IoC.Application.GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }

        #endregion

    }
}
