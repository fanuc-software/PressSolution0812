using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaHydrDieCushionPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubHydrDieCushionPage : Page
    {
        public ParaSubHydrDieCushionPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubHydrDieCushionPageViewModel>();
        }
    }
}
