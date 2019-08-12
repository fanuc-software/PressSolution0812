using System;
using System.Windows.Data;
using System.Globalization;

namespace PressHmi.View.Converters
{

    [ValueConversion(typeof(int), typeof(string))]
    public class CylinderModeStringConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            int temp = (int)value;
            if (temp == 0) return "断开";
            if (temp == 1) return "微调";
            if (temp == 2) return "寸动";
            if (temp == 3) return "单次";
            if (temp == 4) return "连续";
            else return "未知";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
