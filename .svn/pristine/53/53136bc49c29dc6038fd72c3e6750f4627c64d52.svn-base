using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Videotheque.Converters
{
    public class OuiNonConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !(value is bool))
                return "Non";

            return (bool)value ? "Oui" : "Non";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !(value is string) || !((string)value == "Oui" || (string)value == "Non"))
                return false;

            return (string)value == "Oui" ? true : false;
        }
    }
}
