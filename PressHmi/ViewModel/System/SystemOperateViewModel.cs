using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;
using AutoMapper;
using PressHmi.Model;
using PressHmi.View;
using FanucCnc;
using FanucCnc.Model;
using DataCenter.Services;
using FanucCnc.Enum;
using System.Windows;

namespace PressHmi.ViewModel
{
    public class SystemOperateViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand QuitAppCommand { get; set; }

        public SystemOperateViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            QuitAppCommand = new RelayCommand(OnQuitAppCommand);
        }

        private void OnQuitAppCommand()
        {
            MessageBoxResult result = MessageBox.Show("确定是退出吗？", "询问", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //关闭窗口
            if (result == MessageBoxResult.Yes)
            {
                _fanuc.ScannerStatic_Cancel();
                _fanuc.SimulateMonitorLine_Cancel();
                _fanuc.ScannerPage_Cancel();

                var csd = CncScreenDisplay.CreateInstance();
                //csd.StopRefreshCncScreenDisplay();
                csd.ServerStop();

                //发送关闭软件的消息
                Messenger.Default.Send<GenericMessage<string>>(new GenericMessage<string>(""), "SoftwareQuitMsg");
            }
        }
    }
}
