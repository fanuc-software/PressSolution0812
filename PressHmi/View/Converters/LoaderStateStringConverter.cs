using System;
using System.Windows.Data;
using System.Globalization;

namespace PressHmi.View.Converters
{

    [ValueConversion(typeof(int), typeof(string))]
    public class LoaderStateStringConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            int temp = (int)value;
            if (temp == 0) return "未使用";
            if (temp == 2) return "正常";
            if (temp == 3) return "急停";
            if (temp == 4) return "故障";
            if (temp == 5) return "通讯异常";
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