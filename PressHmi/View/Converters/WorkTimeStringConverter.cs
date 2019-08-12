using System;
using System.Windows.Data;
using System.Globalization;

namespace PressHmi.View.Converters
{

    [ValueConversion(typeof(int), typeof(string))]
    public class WorkTimeStringConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            int temp = (int)value;
            if (temp == 0) return "节拍字符串1";
            else return "节拍字符串2";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}