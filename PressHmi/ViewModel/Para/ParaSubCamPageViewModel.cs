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
    public class ParaSubCamPageViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }
        public ICommand StartPos_1SetCmd { get; set; }
        public ICommand EndPos_1SetCmd { get; set; }
        public ICommand StartPos_2SetCmd { get; set; }
        public ICommand EndPos_2SetCmd { get; set; }
        public ICommand StartPos_3SetCmd { get; set; }
        public ICommand EndPos_3SetCmd { get; set; }
        public ICommand StartPos_4SetCmd { get; set; }
        public ICommand EndPos_4SetCmd { get; set; }

        public ICommand StartArr_1SetCmd { get; set; }
        public ICommand StartArr_2SetCmd { get; set; }
        public ICommand StartArr_3SetCmd { get; set; }
        public ICommand StartArr_4SetCmd { get; set; }
        public ICommand EndArr_1SetCmd { get; set; }
        public ICommand EndArr_2SetCmd { get; set; }
        public ICommand EndArr_3SetCmd { get; set; }
        public ICommand EndArr_4SetCmd { get; set; }

        public ICommand Enable_1SetCmd { get; set; }
        public ICommand Enable_2SetCmd { get; set; }
        public ICommand Enable_3SetCmd { get; set; }
        public ICommand Enable_4SetCmd { get; set; }

        private ParaCamInfoDto m_ParaCamInfo = new ParaCamInfoDto();
        public ParaCamInfoDto ParaCamInfo
        {
            get { return m_ParaCamInfo; }
            set
            {
                if (m_ParaCamInfo != value)
                {
                    m_ParaCamInfo = value;
                    RaisePropertyChanged(() => ParaCamInfo);
                }
            }
        }

        public ParaSubCamPageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);
            StartPos_1SetCmd = new RelayCommand(OnStartPos_1Set);
            StartPos_2SetCmd = new RelayCommand(OnStartPos_2Set);
            StartPos_3SetCmd = new RelayCommand(OnStartPos_3Set);
            StartPos_4SetCmd = new RelayCommand(OnStartPos_4Set);
            EndPos_1SetCmd = new RelayCommand(OnEndPos_1Set);
            EndPos_2SetCmd = new RelayCommand(OnEndPos_2Set);
            EndPos_3SetCmd = new RelayCommand(OnEndPos_3Set);
            EndPos_4SetCmd = new RelayCommand(OnEndPos_4Set);

            StartArr_1SetCmd = new RelayCommand(OnStartArr_1Set);
            StartArr_2SetCmd = new RelayCommand(OnStartArr_2Set);
            StartArr_3SetCmd = new RelayCommand(OnStartArr_3Set);
            StartArr_4SetCmd = new RelayCommand(OnStartArr_4Set);
            EndArr_1SetCmd = new RelayCommand(OnEndArr_1Set);
            EndArr_2SetCmd = new RelayCommand(OnEndArr_2Set);
            EndArr_3SetCmd = new RelayCommand(OnEndArr_3Set);
            EndArr_4SetCmd = new RelayCommand(OnEndArr_4Set);

            Enable_1SetCmd = new RelayCommand(OnEnable_1Set);
            Enable_2SetCmd = new RelayCommand(OnEnable_2Set);
            Enable_3SetCmd = new RelayCommand(OnEnable_3Set);
            Enable_4SetCmd = new RelayCommand(OnEnable_4Set);


            Messenger.Default.Register<ParaCamInfo>(this, "ParaCamInfoMsg", msg =>
            {
                ParaCamInfo = _mapper.Map<ParaCamInfo, ParaCamInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(paracam: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnEnable_1Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_Enable_1);
        }
        private void OnEnable_2Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_Enable_2);
        }

        private void OnEnable_3Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_Enable_3);
        }

        private void OnEnable_4Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_Enable_4);
        }

        private void OnStartArr_1Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_StartArr_1);
        }
        private void OnStartArr_2Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_StartArr_2);
        }
        private void OnStartArr_3Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_StartArr_3);
        }
        private void OnStartArr_4Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_StartArr_4);
        }
        private void OnEndArr_1Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_EndArr_1);
        }
        private void OnEndArr_2Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_EndArr_2);
        }
        private void OnEndArr_3Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_EndArr_3);
        }
        private void OnEndArr_4Set()
        {
            _fanuc.ChangePmcBit(_fanuc.CurPmcBom.CAM_EndArr_4);
        }

        private void OnStartPos_1Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_StartPos_1, _fanuc.CurLimitBom.CAM_StartPos_1, "输入备用凸轮1开始位置(mm)");
            dlg.ShowDialog();
        }

        private void OnStartPos_2Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_StartPos_2, _fanuc.CurLimitBom.CAM_StartPos_2, "输入备用凸轮2开始位置(mm)");
            dlg.ShowDialog();
        }

        private void OnStartPos_3Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_StartPos_3, _fanuc.CurLimitBom.CAM_StartPos_3, "输入备用凸轮3开始位置(mm)");
            dlg.ShowDialog();
        }

        private void OnStartPos_4Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_StartPos_4, _fanuc.CurLimitBom.CAM_StartPos_4, "输入备用凸轮4开始位置(mm)");
            dlg.ShowDialog();
        }

        private void OnEndPos_1Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_EndPos_1, _fanuc.CurLimitBom.CAM_EndPos_1, "输入备用凸轮1结束位置(mm)");
            dlg.ShowDialog();
        }

        private void OnEndPos_2Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_EndPos_2, _fanuc.CurLimitBom.CAM_EndPos_2, "输入备用凸轮2结束位置(mm)");
            dlg.ShowDialog();
        }

        private void OnEndPos_3Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_EndPos_3, _fanuc.CurLimitBom.CAM_EndPos_3, "输入备用凸轮3结束位置(mm)");
            dlg.ShowDialog();
        }

        private void OnEndPos_4Set()
        {
            var dlg = new DataInputDialog(_fanuc, _fanuc.CurPmcBom.CAM_EndPos_4, _fanuc.CurLimitBom.CAM_EndPos_4, "输入备用凸轮4结束位置(mm)");
            dlg.ShowDialog();
        }
    }
}
