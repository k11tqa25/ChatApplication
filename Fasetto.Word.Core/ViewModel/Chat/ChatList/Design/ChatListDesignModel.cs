using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListDesignModel: ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of a design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>()
            {
                new ChatListItemViewModel
                {
                    Initials = "KT",
                    Name = "Kevin",
                    Message = "This new chat app is awesome! Make this longer to check the text trimming",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true                    
                 },  
                new ChatListItemViewModel
                {
                    Initials = "SS",
                    Name = "So so",
                    Message = "This is so so.",
                    ProfilePictureRGB = "fe4503"
                 },
                new ChatListItemViewModel
                {
                    Initials = "VT",
                    Name = "Vincent",
                    Message = "This is Vincent.",
                    ProfilePictureRGB = "00d405",
                    IsSelected  = true            
                 },
                new ChatListItemViewModel
                {
                    Initials = "KT",
                    Name = "Kevin",
                    Message = "This new chat app is awesome! Make this longer to check the text trimming",
                    ProfilePictureRGB = "3099c5"
                 },
                new ChatListItemViewModel
                {
                    Initials = "SS",
                    Name = "So so",
                    Message = "This is so so.",
                    ProfilePictureRGB = "fe4503"
                 },
                new ChatListItemViewModel
                {
                    Initials = "VT",
                    Name = "Vincent",
                    Message = "This is Vincent.",
                    ProfilePictureRGB = "00d405"
                 },
                new ChatListItemViewModel
                {
                    Initials = "KT",
                    Name = "Kevin",
                    Message = "This new chat app is awesome! Make this longer to check the text trimming",
                    ProfilePictureRGB = "3099c5"
                 },
                new ChatListItemViewModel
                {
                    Initials = "SS",
                    Name = "So so",
                    Message = "This is so so.",
                    ProfilePictureRGB = "fe4503"
                 },
                new ChatListItemViewModel
                {
                    Initials = "VT",
                    Name = "Vincent",
                    Message = "This is Vincent.",
                    ProfilePictureRGB = "00d405"
                 }
            };
        }
        #endregion
    }
}
