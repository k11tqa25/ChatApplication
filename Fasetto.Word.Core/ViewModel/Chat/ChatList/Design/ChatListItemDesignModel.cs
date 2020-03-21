namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListItemDesignModel: ChatListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of a design model
        /// </summary>
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListItemDesignModel()
        {
            Initials = "KT";
            Name = "Kevin";
            Message = "This new chat app is awesome! Make this longer to check the text trimming";
            ProfilePictureRGB = "3099c5";
        }
        #endregion
    }
}
