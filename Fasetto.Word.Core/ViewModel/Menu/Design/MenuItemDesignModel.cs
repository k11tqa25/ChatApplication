﻿namespace Fasetto.Word.Core
{ 
    /// <summary>
    /// The design-time data for a <see cref="MenuItemViewModel"/>
    /// </summary>
    public class MenuItemDesignModel: MenuItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of a design model
        /// </summary>
        public static MenuItemDesignModel Instance => new MenuItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuItemDesignModel()
        {
            Text = "Hello world";
            Icon = IconType.File;
        }

        #endregion
    }
}
