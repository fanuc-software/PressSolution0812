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
using System.Collections.ObjectModel;

namespace PressHmi.ViewModel
{
    public class MaintainSubIOPageViewModel :MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }


        private ObservableCollection<IoBomItemDto> m_InputBom = new ObservableCollection<IoBomItemDto>();
        public ObservableCollection<IoBomItemDto> InputBom
        {
            get { return m_InputBom; }
            set
            {
                if (m_InputBom != value)
                {
                    m_InputBom = value;
                    RaisePropertyChanged(() => InputBom);
                }
            }
        }

        private ObservableCollection<IoBomItemDto> m_OutputBom = new ObservableCollection<IoBomItemDto>();
        public ObservableCollection<IoBomItemDto> OutputBom
        {
            get { return m_OutputBom; }
            set
            {
                if (m_OutputBom != value)
                {
                    m_OutputBom = value;
                    RaisePropertyChanged(() => OutputBom);
                }
            }
        }

        public MaintainSubIOPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            Messenger.Default.Register<MaintainIoInfo>(this, "MaintainIoInfoMsg", msg =>
            {
                InputBom = _mapper.Map<ObservableCollection<IoBomItem>, ObservableCollection<IoBomItemDto>>(msg.InputBom);
                OutputBom = _mapper.Map<ObservableCollection<IoBomItem>, ObservableCollection<IoBomItemDto>>(msg.OutputBom);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(mnio: true);
        }

        private void OnUnloaded()
        {

        }
    }
}
