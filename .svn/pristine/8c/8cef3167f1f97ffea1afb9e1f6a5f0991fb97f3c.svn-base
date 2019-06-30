using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Videotheque.Converters
{
    public class TronquerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string))
                return "";

            if (parameter == null || !(parameter is int))
                return value;

            string texte = (string)value;
            int longueur = (int)parameter;

            return texte.Length > longueur ? texte.Substring(0, longueur) : texte;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Pas utilisé
            return "";
        }
    }
}
