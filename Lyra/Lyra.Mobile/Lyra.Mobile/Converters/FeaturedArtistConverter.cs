using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Lyra.Mobile.Converters
{
    class FeaturedArtistConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                List<TrackArtist> artists = value as List<TrackArtist>;

                var ftArtists = artists
                    .Where(i => i.TrackArtistRole == "Feature")
                    .Select(i => i.Artist)
                    .ToList();


                string featuredArtists = "";
                for(int i = 0; i < ftArtists.Count; i++)
                {
                    featuredArtists += ftArtists[i].Name;
                    if(i < ftArtists.Count - 1)
                    {
                        featuredArtists += ", ";
                    }
                }

                return featuredArtists;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
