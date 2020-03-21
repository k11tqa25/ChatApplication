using Fasetto.Word.Core;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in a <see cref="BaseViewModel"/> and returns the specific UI control
    /// that should bind to that type of ViewModel
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public  class PopupConentConverter : BaseValueConverter<PopupConentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ChatAttachmentPopupMenuViewModel  basePopup)
                return new VerticalMenu { DataContext = basePopup.Content };
            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
