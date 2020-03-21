using System;
using System.Globalization;

namespace Fasetto.Word
{
    public class PlaceholderBooleanConverter : BaseMultiValueConverter<PlaceholderBooleanConverter>
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool isFocused = (bool)values[0];
            bool isTyped = (bool)values[1];
            return isFocused && isTyped;
        }

        public override object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
