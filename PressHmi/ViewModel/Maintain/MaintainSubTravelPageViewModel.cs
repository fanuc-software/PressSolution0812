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
    public class MaintainSubTravelPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }


        private MaintainTravelInfoDto m_MaintainTravelInfo = new MaintainTravelInfoDto();
        public MaintainTravelInfoDto MaintainTravelInfo
        {
            get { return m_MaintainTravelInfo; }
            set
            {
                if (m_MaintainTravelInfo != value)
                {
                    m_MaintainTravelInfo = value;
                    RaisePropertyChanged(() => MaintainTravelInfo);
                }
            }
        }

        public MaintainSubTravelPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            Messenger.Default.Register<MaintainTravelInfo>(this, "MaintainTravelInfoMsg", msg =>
            {
                MaintainTravelInfo = _mapper.Map<MaintainTravelInfo, MaintainTravelInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(mntravel : true);
        }

        private void OnUnloaded()
        {

        }
    }
}
