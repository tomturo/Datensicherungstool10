using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Datensicherungstool10.Sonstiges
{
    #region HeaderToImageConverter

    [ValueConversion(typeof(string), typeof(bool))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapSource source = null;
            if ((value as string).Contains(@"\"))
            {
                Uri uri = new Uri("pack://application:,,,/Bilder/Pic_Ordner.png");
                source = new BitmapImage(uri);
                return source;
            }
            //else
            //{
            //    Uri uri = new Uri("pack://application:,,,/Bilder/Pic_Ordner.png");
            //    BitmapImage source = new BitmapImage(uri);
            //    return source;
            //}
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }

    #endregion // DoubleToIntegerConverter
}
