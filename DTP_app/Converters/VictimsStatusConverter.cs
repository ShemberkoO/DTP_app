using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DTP_app.Converters
{
    public class VictimsStatusConverter : IValueConverter
    {
        Dictionary<VictimStatus,BitmapImage> cache = new Dictionary<VictimStatus,BitmapImage>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (VictimStatus) value;
            if (!cache.ContainsKey(status))
            {
                var uri = new Uri(string.Format(@"C:\Users\Developer\Desktop\university\3kurs\1sem\kpz\DTP_app\DTP_app\Images\Victims\{0}.png",status.ToString().ToLower()), UriKind.Absolute);
                cache.Add(status, new BitmapImage(uri));
            }
            
            return cache[status];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
