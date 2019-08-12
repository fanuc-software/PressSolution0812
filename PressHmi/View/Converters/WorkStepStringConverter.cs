using System;
using System.Windows.Data;
using System.Globalization;

namespace PressHmi.View.Converters
{

    [ValueConversion(typeof(int), typeof(string))]
    public class WorkStepStringConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            int temp = (int)value;
            if (temp == 0) return "合模";
            if (temp == 1) return "保压";
            if (temp == 2) return "上行";
            if (temp == 3) return "等待";
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
