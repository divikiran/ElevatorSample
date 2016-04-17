using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElevatorSample.Converters
{
    public class ColorChangeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = (Color)value;
            return color;
            //switch (color)
            //{
            //    case (Color.White):
            //        {
            //            return Color.White;
            //        }
            //    case ("Green"):
            //        {
            //            return Color.Green;
            //        }
            //    default:
            //        {
            //            return Color.White;
            //        }
            //}
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.White;
        }
    }
}
