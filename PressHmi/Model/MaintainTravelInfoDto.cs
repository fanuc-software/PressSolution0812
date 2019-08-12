using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class MaintainTravelInfoDto : ViewModelBase
    {
        private double m_MTO_ServoReady;
        public double MTO_ServoReady
        {
            get { return m_MTO_ServoReady; }
            set
            {
                if (m_MTO_ServoReady != value)
                {
                    m_MTO_ServoReady = value;
                    RaisePropertyChanged(() => MTO_ServoReady);
                }
            }
        }

        private double m_MTO_BL;
        public double MTO_BL
        {
            get { return m_MTO_BL; }
            set
            {
                if (m_MTO_BL != value)
                {
                    m_MTO_BL = value;
                    RaisePropertyChanged(() => MTO_BL);
                }
            }
        }
        private double m_MTO_Lubrication;
        public double MTO_Lubrication
        {
            get { return m_MTO_Lubrication; }
            set
            {
                if (m_MTO_Lubrication != value)
                {
                    m_MTO_Lubrication = value;
                    RaisePropertyChanged(() => MTO_Lubrication);
                }
            }
        }
        private double m_MTO_AirPress;
        public double MTO_AirPress
        {
            get { return m_MTO_AirPress; }
            set
            {
                if (m_MTO_AirPress != value)
                {
                    m_MTO_AirPress = value;
                    RaisePropertyChanged(() => MTO_AirPress);
                }
            }
        }
        private double m_MTO_PE;
        public double MTO_PE
        {
            get { return m_MTO_PE; }
            set
            {
                if (m_MTO_PE != value)
                {
                    m_MTO_PE = value;
                    RaisePropertyChanged(() => MTO_PE);
                }
            }
        }
        private double m_MTO_EMG;
        public double MTO_EMG
        {
            get { return m_MTO_EMG; }
            set
            {
                if (m_MTO_EMG != value)
                {
                    m_MTO_EMG = value;
                    RaisePropertyChanged(() => MTO_EMG);
                }
            }
        }
        private double m_MTO_SafeCock;
        public double MTO_SafeCock
        {
            get { return m_MTO_SafeCock; }
            set
            {
                if (m_MTO_SafeCock != value)
                {
                    m_MTO_SafeCock = value;
                    RaisePropertyChanged(() => MTO_SafeCock);
                }
            }
        }
        private double m_MTO_TableClamp;
        public double MTO_TableClamp
        {
            get { return m_MTO_TableClamp; }
            set
            {
                if (m_MTO_TableClamp != value)
                {
                    m_MTO_TableClamp = value;
                    RaisePropertyChanged(() => MTO_TableClamp);
                }
            }
        }
        private double m_MTO_DieClamp;
        public double MTO_DieClamp
        {
            get { return m_MTO_DieClamp; }
            set
            {
                if (m_MTO_DieClamp != value)
                {
                    m_MTO_DieClamp = value;
                    RaisePropertyChanged(() => MTO_DieClamp);
                }
            }
        }
        private double m_MTO_SafeDoorClose;
        public double MTO_SafeDoorClose
        {
            get { return m_MTO_SafeDoorClose; }
            set
            {
                if (m_MTO_SafeDoorClose != value)
                {
                    m_MTO_SafeDoorClose = value;
                    RaisePropertyChanged(() => MTO_SafeDoorClose);
                }
            }
        }
        private double m_MTO_Counter;
        public double MTO_Counter
        {
            get { return m_MTO_Counter; }
            set
            {
                if (m_MTO_Counter != value)
                {
                    m_MTO_Counter = value;
                    RaisePropertyChanged(() => MTO_Counter);
                }
            }
        }
        private double m_MTO_JOG;
        public double MTO_JOG
        {
            get { return m_MTO_JOG; }
            set
            {
                if (m_MTO_JOG != value)
                {
                    m_MTO_JOG = value;
                    RaisePropertyChanged(() => MTO_JOG);
                }
            }
        }
        private double m_MTO_JOGOK;
        public double MTO_JOGOK
        {
            get { return m_MTO_JOGOK; }
            set
            {
                if (m_MTO_JOGOK != value)
                {
                    m_MTO_JOGOK = value;
                    RaisePropertyChanged(() => MTO_JOGOK);
                }
            }
        }
        private double m_MTO_UpDieCenter;
        public double MTO_UpDieCenter
        {
            get { return m_MTO_UpDieCenter; }
            set
            {
                if (m_MTO_UpDieCenter != value)
                {
                    m_MTO_UpDieCenter = value;
                    RaisePropertyChanged(() => MTO_UpDieCenter);
                }
            }
        }
        private double m_MTO_Single;
        public double MTO_Single
        {
            get { return m_MTO_Single; }
            set
            {
                if (m_MTO_Single != value)
                {
                    m_MTO_Single = value;
                    RaisePropertyChanged(() => MTO_Single);
                }
            }
        }
        private double m_MTO_SingleOK;
        public double MTO_SingleOK
        {
            get { return m_MTO_SingleOK; }
            set
            {
                if (m_MTO_SingleOK != value)
                {
                    m_MTO_SingleOK = value;
                    RaisePropertyChanged(() => MTO_SingleOK);
                }
            }
        }
        private double m_MTO_Continue;
        public double MTO_Continue
        {
            get { return m_MTO_Continue; }
            set
            {
                if (m_MTO_Continue != value)
                {
                    m_MTO_Continue = value;
                    RaisePropertyChanged(() => MTO_Continue);
                }
            }
        }
        private double m_MTO_ContinueOK;
        public double MTO_ContinueOK
        {
            get { return m_MTO_ContinueOK; }
            set
            {
                if (m_MTO_ContinueOK != value)
                {
                    m_MTO_ContinueOK = value;
                    RaisePropertyChanged(() => MTO_ContinueOK);
                }
            }
        }
    }
}
