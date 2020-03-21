using System;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for each chat message thread item in the chat thread
    /// </summary>
    public class ChatMessageListItemViewModel: BaseViewModel
    {
        /// <summary>
        /// The display name of the sender of the message
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// The latest message from this chat
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The initials to show for the profile picture backgound
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the background color of the profile picture
        /// For example FF00FF for Red and Blue mixed
        /// Never puts any type that related to WPF library in a view model
        /// </summary>
        public string ProfilePictureRGB { get; set; }
        
        /// <summary>
        /// True if thie item is selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// True if this message was sent by the signed in user
        /// </summary>
        public  bool SentByMe { get; set; }

        /// <summary>
        /// The time the message was read, or <see cref="DateTimeOffset.MinValue"/> if not read
        /// </summary>
        public DateTimeOffset MessageReadTime { get; set; }

        /// <summary>
        /// True if this message is read
        /// </summary>
        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

        /// <summary>
        /// The time the message was sent
        /// </summary>
        public DateTimeOffset MessageSentTime { get; set; }        
    }
}
