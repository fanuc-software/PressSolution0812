using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
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

namespace PressHmi.ViewModel
{
    public class MaintainSubServoPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }


        private MaintainServoInfoDto m_MaintainServoInfo = new MaintainServoInfoDto();
        public MaintainServoInfoDto MaintainServoInfo
        {
            get { return m_MaintainServoInfo; }
            set
            {
                if (m_MaintainServoInfo != value)
                {
                    m_MaintainServoInfo = value;
                    RaisePropertyChanged(() => MaintainServoInfo);
                }
            }
        }

        public MaintainSubServoPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            Messenger.Default.Register<MaintainServoInfo>(this, "MaintainServoInfoMsg", msg =>
            {
                MaintainServoInfo = _mapper.Map<MaintainServoInfo, MaintainServoInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(mnservo : true);
        }

        private void OnUnloaded()
        {

        }
    }
}
