﻿using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for any popup menu
    /// </summary>
    public class ChatAttachmentPopupMenuViewModel : BasePopupViewModel
    {
        #region Public Properties


        #endregion

        #region Constructor

        public ChatAttachmentPopupMenuViewModel()
        {
            Content = new MenuViewModel()
            {
                Items = new List<MenuItemViewModel>()
                {
                    new MenuItemViewModel{Type = MenuItemType.Header, Text = "Attach a file..." },
                    new MenuItemViewModel{Text = "From computer", Icon= IconType.File },
                    new MenuItemViewModel{Text = "From pictures", Icon= IconType.Picture }
                }
            };
        }

        #endregion
    }
}
