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
    public class MaintainSubMoveTablePageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }


        private MaintainMoveTableInfoDto m_MaintainMoveTableInfo = new MaintainMoveTableInfoDto();
        public MaintainMoveTableInfoDto MaintainMoveTableInfo
        {
            get { return m_MaintainMoveTableInfo; }
            set
            {
                if (m_MaintainMoveTableInfo != value)
                {
                    m_MaintainMoveTableInfo = value;
                    RaisePropertyChanged(() => MaintainMoveTableInfo);
                }
            }
        }

        public MaintainSubMoveTablePageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            Messenger.Default.Register<MaintainMoveTableInfo>(this, "MaintainMoveTableInfoMsg", msg =>
            {
                MaintainMoveTableInfo = _mapper.Map<MaintainMoveTableInfo, MaintainMoveTableInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(mnmovetable : true);
        }

        private void OnUnloaded()
        {

        }
    }
}
