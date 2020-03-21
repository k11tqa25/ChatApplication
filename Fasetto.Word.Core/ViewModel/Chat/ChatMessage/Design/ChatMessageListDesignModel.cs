using System;
using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatMessageListDesignModel"/>
    /// </summary>
    public class ChatMessageListDesignModel: ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of a design model
        /// </summary>
        public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel();

        #endregion


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListDesignModel()
        {
            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel
                {
                    SenderName = "Vincent",
                    Initials = "VC",
                    Message = "I'm about to wipe the old server. We need to update the old server to Windows 2016",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false,
                },
                new ChatMessageListItemViewModel
                {
                    SenderName = "Kevin",
                    Initials = "KT",
                    Message = "Let me know when you manage to spin up the new 2016 server",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    MessageReadTime =  DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                    SentByMe = true,
                },
                new ChatMessageListItemViewModel
                {
                    SenderName = "Vincent",
                    Initials = "VC",
                    Message = "The new server is up. Got to 192.168.1.1.\r\n Username is admin, paswsword is P8ssw0rd",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false,
                    
                },
            };
        }
        #endregion
    }
}
