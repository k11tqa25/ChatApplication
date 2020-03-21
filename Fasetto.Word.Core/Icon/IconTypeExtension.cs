namespace Fasetto.Word.Core
{
    /// <summary>
    /// Helper functions for <see cref="IconType"/> 
    /// </summary>
    public static class IconTypeExtension
    {
        /// <summary>
        /// Converts <see cref="IconType"/> to a FontAwesome string
        /// </summary>
        /// <param name="type">The type to convert</param>
        public static string ToFontAwesome(this IconType type)
        {
            // Return a FontAwesome string based on the icon type
            switch (type)
            {
                case IconType.File:
                    return "\uf15c";

                case IconType.Picture:
                    return "\uf1c5";

                // If not found, return null
                default:
                    return null;
            }
        }
    }
}
