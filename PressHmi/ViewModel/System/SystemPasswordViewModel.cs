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

namespace PressHmi.ViewModel
{
    public class SystemPasswordViewModel : MyBaseViewModel
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        private string m_OperatorPwd;
        public string OperatorPwd
        {
            get { return m_OperatorPwd; }
            set
            {
                if (m_OperatorPwd != value)
                {
                    m_OperatorPwd = value;
                    RaisePropertyChanged(() => OperatorPwd);
                }
            }
        }

        private string m_ManagerPwd;
        public string ManagerPwd
        {
            get { return m_ManagerPwd; }
            set
            {
                if (m_ManagerPwd != value)
                {
                    m_ManagerPwd = value;
                    RaisePropertyChanged(() => ManagerPwd);
                }
            }
        }

        private string m_MtbPwd;
        public string MtbPwd
        {
            get { return m_MtbPwd; }
            set
            {
                if (m_MtbPwd != value)
                {
                    m_MtbPwd = value;
                    RaisePropertyChanged(() => MtbPwd);
                }
            }
        }

        private string m_BfmPwd;
        public string BfmPwd
        {
            get { return m_BfmPwd; }
            set
            {
                if (m_BfmPwd != value)
                {
                    m_BfmPwd = value;
                    RaisePropertyChanged(() => BfmPwd);
                }
            }
        }

        public ICommand SavePwdCommand { get; set; }

        public SystemPasswordViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            SavePwdCommand = new RelayCommand(OnSavePwdCommand);
        }

        private void OnSavePwdCommand()
        {
            var srv = new RoleInfoService();
            if(OperatorPwd != null && OperatorPwd != "")
            {
                srv.UpdataAuthR((int)OperatorAuthTypeEnum.OPERATOR, OperatorPwd);
            }
            if (ManagerPwd != null && ManagerPwd != "")
            {
                srv.UpdataAuthR((int)OperatorAuthTypeEnum.MANAGER, ManagerPwd);
            }
            if (MtbPwd != null && MtbPwd != "")
            {
                srv.UpdataAuthR((int)OperatorAuthTypeEnum.MTB, MtbPwd);
            }
            if (BfmPwd != null && BfmPwd != "")
            {
                srv.UpdataAuthR((int)OperatorAuthTypeEnum.BFM, BfmPwd);
            }
        }
    }
}
