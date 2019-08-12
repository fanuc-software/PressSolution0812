using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// ParaSubCamPage.xaml 的交互逻辑
    /// </summary>
    public partial class ParaSubCamPage : Page
    {
        public ParaSubCamPage()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<ParaSubCamPageViewModel>();
        }
    }
}
