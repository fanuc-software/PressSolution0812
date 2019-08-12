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
    public class ParaSubHydrDieCushionPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }
        public ICommand StartPos_1SetCmd { get; set; }
        public ICommand EndPos_1SetCmd { get; set; }
        public ICommand StartPos_2SetCmd { get; set; }
        public ICommand EndPos_2SetCmd { get; set; }

        public ICommand StartArr_1SetCmd { get; set; }
        public ICommand StartArr_2SetCmd { get; set; }
        public ICommand EndArr_1SetCmd { get; set; }
        public ICommand EndArr_2SetCmd { get; set; }

        public ICommand Enable_1SetCmd { get; set; }
        public ICommand Enable_2SetCmd { get; set; }

        private ParaHydrDieCushionInfoDto m_ParaHydrDieCushionInfo = new ParaHydrDieCushionInfoDto();
        public ParaHydrDieCushionInfoDto ParaHydrDieCushionInfo
        {
            get { return m_ParaHydrDieCushionInfo; }
            set
            {
                if (m_ParaHydrDieCushionInfo != value)
                {
                    m_ParaHydrDieCushionInfo = value;
                    RaisePropertyChanged(() => ParaHydrDieCushionInfo);
                }
            }
        }

        public ParaSubHydrDieCushionPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            StartPos_1SetCmd = new RelayCommand(OnStartPos_1Set);
            StartPos_2SetCmd = new RelayCommand(OnStartPos_2Set);
            EndPos_1SetCmd = new RelayCommand(OnEndPos_1Set);
            EndPos_2SetCmd = new RelayCommand(OnEndPos_2Set);

            StartArr_1SetCmd = new RelayCommand(OnStartArr_1Set);
            StartArr_2SetCmd = new RelayCommand(OnStartArr_2Set);
            EndArr_1SetCmd = new RelayCommand(OnEndArr_1Set);
            EndArr_2SetCmd = new RelayCommand(OnEndArr_2Set);

            Enable_1SetCmd = new RelayCommand(OnEnable_1Set);
            Enable_2SetCmd = new RelayCommand(OnEnable_2Set);

            Messenger.Default.Register<ParaHydrDieCushionInfo>(this, "ParaHydrDieCushionInfoMsg", msg =>
            {
                ParaHydrDieCushionInfo = _mapper.Map<ParaHydrDieCushionInfo, ParaHydrDieCushionInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(parahydrdiecushion: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnEnable_1Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.HDC_Enable_1);
        }
        private void OnEnable_2Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.HDC_Enable_2);
        }

        private void OnStartArr_1Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.HDC_StartArr_1);
        }
        private void OnStartArr_2Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.HDC_StartArr_2);
        }
        private void OnEndArr_1Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.HDC_EndArr_1);
        }
        private void OnEndArr_2Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.HDC_EndArr_2);
        }

        private void OnStartPos_1Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.HDC_StartPos_1, _fanuc.CurLimitBom.HDC_StartPos_1, "输入液压垫控制1开始位置(mm)");
            dlg.ShowDialog();
        }

        private void OnStartPos_2Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.HDC_StartPos_2, _fanuc.CurLimitBom.HDC_StartPos_2, "输入液压垫控制2开始位置(mm)");
            dlg.ShowDialog();
        }

        private void OnEndPos_1Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.HDC_EndPos_1, _fanuc.CurLimitBom.HDC_EndPos_1, "输入液压垫控制1结束位置(mm)");
            dlg.ShowDialog();
        }

        private void OnEndPos_2Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.HDC_EndPos_2, _fanuc.CurLimitBom.HDC_EndPos_2, "输入液压垫控制2结束位置(mm)");
            dlg.ShowDialog();
        }

    }
}
