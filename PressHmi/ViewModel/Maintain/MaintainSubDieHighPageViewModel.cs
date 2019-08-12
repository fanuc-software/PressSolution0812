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
    public class MaintainSubDieHighPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }


        private MaintainDieHighInfoDto m_MaintainDieHighInfo = new MaintainDieHighInfoDto();
        public MaintainDieHighInfoDto MaintainDieHighInfo
        {
            get { return m_MaintainDieHighInfo; }
            set
            {
                if (m_MaintainDieHighInfo != value)
                {
                    m_MaintainDieHighInfo = value;
                    RaisePropertyChanged(() => MaintainDieHighInfo);
                }
            }
        }

        public MaintainSubDieHighPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            Messenger.Default.Register<MaintainDieHighInfo>(this, "MaintainDieHighInfoMsg", msg =>
            {
                MaintainDieHighInfo = _mapper.Map<MaintainDieHighInfo, MaintainDieHighInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(mndiehigh: true);
        }

        private void OnUnloaded()
        {

        }
    }
}
