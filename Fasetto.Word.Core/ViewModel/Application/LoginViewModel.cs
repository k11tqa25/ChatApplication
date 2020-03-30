using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel: BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

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

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString" />passed in from the view for the users password.</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(1000);

                //var email = Email;

                //// IMPORTANT: Never store imsecure password in variable like this
                //var pass = (parameter as IHavePassword).SecurePassword.Unsecure();

                // Go to chat page
                IoC.Application.GoToPage(ApplicationPage.Chat);
            });
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            // Go to register page
            IoC.Application.GoToPage(ApplicationPage.Register);
            await Task.Delay(1);
        }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            // Create commands
            LoginCommand = new RelayParamatizedCommand(async (parameter) => await LoginAsync(parameter));
            // Create commands
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }

        #endregion

    }
}
