using System;
using System.Globalization;
using Prism.Services;
using Xamarin.Forms;

namespace PrismFormsUpdatedSample.Converters
{
    public class TextToColorConverter : IValueConverter
    {
        private IDeviceService _deviceService { get; }

        public TextToColorConverter(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (_deviceService.Idiom == TargetIdiom.Phone) ? Color.Red : Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (_deviceService.Idiom == TargetIdiom.Phone) ? Color.Red : Color.Black;
        }
    }
}