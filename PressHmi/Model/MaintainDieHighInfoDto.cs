using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class MaintainDieHighInfoDto : ViewModelBase
    {
        private double m_MDH_SEL;
        public double MDH_SEL
        {
            get { return m_MDH_SEL; }
            set
            {
                if (m_MDH_SEL != value)
                {
                    m_MDH_SEL = value;
                    RaisePropertyChanged(() => MDH_SEL);
                }
            }
        }
        private double m_MDH_BL;
        public double MDH_BL
        {
            get { return m_MDH_BL; }
            set
            {
                if (m_MDH_BL != value)
                {
                    m_MDH_BL = value;
                    RaisePropertyChanged(() => MDH_BL);
                }
            }
        }
        private double m_MDH_SafeCock;
        public double MDH_SafeCock
        {
            get { return m_MDH_SafeCock; }
            set
            {
                if (m_MDH_SafeCock != value)
                {
                    m_MDH_SafeCock = value;
                    RaisePropertyChanged(() => MDH_SafeCock);
                }
            }
        }
        private double m_MDH_TableClamped;
        public double MDH_TableClamped
        {
            get { return m_MDH_TableClamped; }
            set
            {
                if (m_MDH_TableClamped != value)
                {
                    m_MDH_TableClamped = value;
                    RaisePropertyChanged(() => MDH_TableClamped);
                }
            }
        }
        private double m_MDH_Emg;
        public double MDH_Emg
        {
            get { return m_MDH_Emg; }
            set
            {
                if (m_MDH_Emg != value)
                {
                    m_MDH_Emg = value;
                    RaisePropertyChanged(() => MDH_Emg);
                }
            }
        }
        private double m_MDH_MoveTableAmp;
        public double MDH_MoveTableAmp
        {
            get { return m_MDH_MoveTableAmp; }
            set
            {
                if (m_MDH_MoveTableAmp != value)
                {
                    m_MDH_MoveTableAmp = value;
                    RaisePropertyChanged(() => MDH_MoveTableAmp);
                }
            }
        }
        private double m_MDH_Manual;
        public double MDH_Manual
        {
            get { return m_MDH_Manual; }
            set
            {
                if (m_MDH_Manual != value)
                {
                    m_MDH_Manual = value;
                    RaisePropertyChanged(() => MDH_Manual);
                }
            }
        }
        private double m_MDH_UnLimitDown;
        public double MDH_UnLimitDown
        {
            get { return m_MDH_UnLimitDown; }
            set
            {
                if (m_MDH_UnLimitDown != value)
                {
                    m_MDH_UnLimitDown = value;
                    RaisePropertyChanged(() => MDH_UnLimitDown);
                }
            }
        }
        private double m_MDH_UnLimitUp;
        public double MDH_UnLimitUp
        {
            get { return m_MDH_UnLimitUp; }
            set
            {
                if (m_MDH_UnLimitUp != value)
                {
                    m_MDH_UnLimitUp = value;
                    RaisePropertyChanged(() => MDH_UnLimitUp);
                }
            }
        }
        private double m_MDH_ManualDown;
        public double MDH_ManualDown
        {
            get { return m_MDH_ManualDown; }
            set
            {
                if (m_MDH_ManualDown != value)
                {
                    m_MDH_ManualDown = value;
                    RaisePropertyChanged(() => MDH_ManualDown);
                }
            }
        }
        private double m_MDH_ManualUp;
        public double MDH_ManualUp
        {
            get { return m_MDH_ManualUp; }
            set
            {
                if (m_MDH_ManualUp != value)
                {
                    m_MDH_ManualUp = value;
                    RaisePropertyChanged(() => MDH_ManualUp);
                }
            }
        }
        private double m_MDH_Auto;
        public double MDH_Auto
        {
            get { return m_MDH_Auto; }
            set
            {
                if (m_MDH_Auto != value)
                {
                    m_MDH_Auto = value;
                    RaisePropertyChanged(() => MDH_Auto);
                }
            }
        }
        private double m_MDH_UpDieCenter;
        public double MDH_UpDieCenter
        {
            get { return m_MDH_UpDieCenter; }
            set
            {
                if (m_MDH_UpDieCenter != value)
                {
                    m_MDH_UpDieCenter = value;
                    RaisePropertyChanged(() => MDH_UpDieCenter);
                }
            }
        }
        private double m_MDH_AutoAllowUp;
        public double MDH_AutoAllowUp
        {
            get { return m_MDH_AutoAllowUp; }
            set
            {
                if (m_MDH_AutoAllowUp != value)
                {
                    m_MDH_AutoAllowUp = value;
                    RaisePropertyChanged(() => MDH_AutoAllowUp);
                }
            }
        }
        private double m_MDH_AutoAllowDown;
        public double MDH_AutoAllowDown
        {
            get { return m_MDH_AutoAllowDown; }
            set
            {
                if (m_MDH_AutoAllowDown != value)
                {
                    m_MDH_AutoAllowDown = value;
                    RaisePropertyChanged(() => MDH_AutoAllowDown);
                }
            }
        }
        private double m_MDH_AutoUp;
        public double MDH_AutoUp
        {
            get { return m_MDH_AutoUp; }
            set
            {
                if (m_MDH_AutoUp != value)
                {
                    m_MDH_AutoUp = value;
                    RaisePropertyChanged(() => MDH_AutoUp);
                }
            }
        }
        private double m_MDH_AutoDown;
        public double MDH_AutoDown
        {
            get { return m_MDH_AutoDown; }
            set
            {
                if (m_MDH_AutoDown != value)
                {
                    m_MDH_AutoDown = value;
                    RaisePropertyChanged(() => MDH_AutoDown);
                }
            }
        }
    }
}
