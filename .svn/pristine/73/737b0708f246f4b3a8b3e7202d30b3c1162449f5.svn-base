using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Videotheque.Converters
{
    public class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !(value is int) || ((int)value) == 0)
                return "Sans";

            return ((int)value) + " ans";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null || !(value is string) || ((string)value).Length == 0)
                return 0;

            if (int.TryParse(((string)value).Split(' ')[0], out int retour))
                return retour;
            else
                return 0;
        }
    }
}
