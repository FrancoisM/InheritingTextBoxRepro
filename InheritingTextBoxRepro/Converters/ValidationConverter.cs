using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace InheritingTextBoxRepro.Converters
{
    public class ValidationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language) => (bool)value ? new SolidColorBrush(Colors.PaleGreen) : new SolidColorBrush(Colors.OrangeRed);
        public object ConvertBack(object value, Type targetType, object parameter, string language) => throw new NotImplementedException();
    }
}
