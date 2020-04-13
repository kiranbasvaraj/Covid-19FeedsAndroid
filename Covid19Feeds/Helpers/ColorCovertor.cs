using System;
using System.Globalization;
using WantToWork.Helpers;
using Xamarin.Forms;
using System.Linq;

namespace Covid19Feeds.Helpers
{
    public class ColorCovertor : IValueConverter
    {

        public string mcolor;
        int count = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {

                if (count <= AppConstants.ColorList.Count)
                {
                    mcolor = (AppConstants.ColorList[count]).Color;
                    count++;
                    //var random = new Random();
                    //var val = random.Next(AppConstants.ColorList.Count);

                }
            }
            catch (Exception ex)
            {

            }
            return mcolor;

        }
           

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
