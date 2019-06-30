using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Videotheque.Converters
{
    public class CaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !(value is string) || ((string)value).Length == 0 || parameter is null || !(parameter is string) || !(((string)parameter) == "u" || ((string)parameter) == "l"))
                return "";

            return ((string)parameter) == "u" ? ((string)value).ToUpper() : ((string)value).ToLower();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !(value is string) || ((string)value).Length == 0 || parameter is null || !(parameter is string) || !(((string)parameter) == "u" || ((string)parameter) == "l"))
                return "";

            return ((string)parameter) == "u" ? ((string)value).ToUpper() : ((string)value).ToLower();
        }
    }
}
