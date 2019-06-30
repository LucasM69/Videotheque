using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace Videotheque.Converters
{
    public class TextToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Entré => double, Sortie => String
            if (value == null || !(value is double))
                return "0";

            return ((double)value).ToString(CultureInfo.CreateSpecificCulture("en-EN"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Entré => String, Sortie => double
            if(value == null || !(value is string))
                return 0;

            string valeur = "";
            bool verifUneVirgule = false;
            foreach (char c in ((string)value).Replace(',', '.'))
            {
                if (char.IsNumber(c))
                    valeur += c;
                else if(c.Equals('.') && !verifUneVirgule)
                {
                    valeur += c;
                    verifUneVirgule = true;
                }
            }

            if (valeur.Length == 0)
                return 0;

            if (valeur[valeur.Length - 1].Equals('.'))
                valeur += "0";

            return double.Parse(valeur, CultureInfo.CreateSpecificCulture("en-EN"));
        }
    }
}
