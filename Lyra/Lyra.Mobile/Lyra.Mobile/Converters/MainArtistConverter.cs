using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Lyra.Mobile.Converters
{
    public class MainArtistConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                List<TrackArtist> artists = value as List<TrackArtist>;

                var mainArtist = artists
                    .Where(i => i.TrackArtistRole == "Main")
                    .Select(i => i.Artist)
                    .FirstOrDefault();
                return mainArtist?.Name;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
