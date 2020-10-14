using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace clemessywpf.Converters
{
    public class ErrorsConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var txt = $"Il y a {values[1]} erreur(s): ";
            var tab = values[0] as IEnumerable<ValidationError>;

            foreach (var item in tab)
            {
                txt += item.ErrorContent.ToString();
            }

            return txt;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
