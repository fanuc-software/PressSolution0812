using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using PressHmi.ViewModel;

namespace PressHmi.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<MainWindowViewModel>();

            Messenger.Default.Register<GenericMessage<string>>(this, "SoftwareQuitMsg", msg =>
            {
                this.Close();
            });
        }
    }
}
