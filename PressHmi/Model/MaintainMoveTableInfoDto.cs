using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class MaintainMoveTableInfoDto : ViewModelBase
    {
        private double m_MMT_MovePump;
        public double MMT_MovePump
        {
            get { return m_MMT_MovePump; }
            set
            {
                if (m_MMT_MovePump != value)
                {
                    m_MMT_MovePump = value;
                    RaisePropertyChanged(() => MMT_MovePump);
                }
            }
        }
        private double m_MMT_EMG;
        public double MMT_EMG
        {
            get { return m_MMT_EMG; }
            set
            {
                if (m_MMT_EMG != value)
                {
                    m_MMT_EMG = value;
                    RaisePropertyChanged(() => MMT_EMG);
                }
            }
        }
        private double m_MMT_ChangeMode;
        public double MMT_ChangeMode
        {
            get { return m_MMT_ChangeMode; }
            set
            {
                if (m_MMT_ChangeMode != value)
                {
                    m_MMT_ChangeMode = value;
                    RaisePropertyChanged(() => MMT_ChangeMode);
                }
            }
        }
        private double m_MMT_UpDieCenter;
        public double MMT_UpDieCenter
        {
            get { return m_MMT_UpDieCenter; }
            set
            {
                if (m_MMT_UpDieCenter != value)
                {
                    m_MMT_UpDieCenter = value;
                    RaisePropertyChanged(() => MMT_UpDieCenter);
                }
            }
        }
        private double m_MMT_UpBTN;
        public double MMT_UpBTN
        {
            get { return m_MMT_UpBTN; }
            set
            {
                if (m_MMT_UpBTN != value)
                {
                    m_MMT_UpBTN = value;
                    RaisePropertyChanged(() => MMT_UpBTN);
                }
            }
        }
        private double m_MMT_PumpStation;
        public double MMT_PumpStation
        {
            get { return m_MMT_PumpStation; }
            set
            {
                if (m_MMT_PumpStation != value)
                {
                    m_MMT_PumpStation = value;
                    RaisePropertyChanged(() => MMT_PumpStation);
                }
            }
        }
        private double m_MMT_OUT_Mag;
        public double MMT_OUT_Mag
        {
            get { return m_MMT_OUT_Mag; }
            set
            {
                if (m_MMT_OUT_Mag != value)
                {
                    m_MMT_OUT_Mag = value;
                    RaisePropertyChanged(() => MMT_OUT_Mag);
                }
            }
        }
        private double m_MMT_UpTimeOut;
        public double MMT_UpTimeOut
        {
            get { return m_MMT_UpTimeOut; }
            set
            {
                if (m_MMT_UpTimeOut != value)
                {
                    m_MMT_UpTimeOut = value;
                    RaisePropertyChanged(() => MMT_UpTimeOut);
                }
            }
        }
        private double m_MMT_UpFin;
        public double MMT_UpFin
        {
            get { return m_MMT_UpFin; }
            set
            {
                if (m_MMT_UpFin != value)
                {
                    m_MMT_UpFin = value;
                    RaisePropertyChanged(() => MMT_UpFin);
                }
            }
        }
        private double m_MMT_MoveAmp;
        public double MMT_MoveAmp
        {
            get { return m_MMT_MoveAmp; }
            set
            {
                if (m_MMT_MoveAmp != value)
                {
                    m_MMT_MoveAmp = value;
                    RaisePropertyChanged(() => MMT_MoveAmp);
                }
            }
        }
        private double m_MMT_SafeDoorOpen;
        public double MMT_SafeDoorOpen
        {
            get { return m_MMT_SafeDoorOpen; }
            set
            {
                if (m_MMT_SafeDoorOpen != value)
                {
                    m_MMT_SafeDoorOpen = value;
                    RaisePropertyChanged(() => MMT_SafeDoorOpen);
                }
            }
        }
        private double m_MMT_MoveOutBTN;
        public double MMT_MoveOutBTN
        {
            get { return m_MMT_MoveOutBTN; }
            set
            {
                if (m_MMT_MoveOutBTN != value)
                {
                    m_MMT_MoveOutBTN = value;
                    RaisePropertyChanged(() => MMT_MoveOutBTN);
                }
            }
        }
        private double m_MMT_MoveOutFin;
        public double MMT_MoveOutFin
        {
            get { return m_MMT_MoveOutFin; }
            set
            {
                if (m_MMT_MoveOutFin != value)
                {
                    m_MMT_MoveOutFin = value;
                    RaisePropertyChanged(() => MMT_MoveOutFin);
                }
            }
        }
        private double m_MMT_TwinTable;
        public double MMT_TwinTable
        {
            get { return m_MMT_TwinTable; }
            set
            {
                if (m_MMT_TwinTable != value)
                {
                    m_MMT_TwinTable = value;
                    RaisePropertyChanged(() => MMT_TwinTable);
                }
            }
        }
        private double m_MMT_MoveInBTN;
        public double MMT_MoveInBTN
        {
            get { return m_MMT_MoveInBTN; }
            set
            {
                if (m_MMT_MoveInBTN != value)
                {
                    m_MMT_MoveInBTN = value;
                    RaisePropertyChanged(() => MMT_MoveInBTN);
                }
            }
        }
        private double m_MMT_MoveInFin;
        public double MMT_MoveInFin
        {
            get { return m_MMT_MoveInFin; }
            set
            {
                if (m_MMT_MoveInFin != value)
                {
                    m_MMT_MoveInFin = value;
                    RaisePropertyChanged(() => MMT_MoveInFin);
                }
            }
        }
        private double m_MMT_ClampBTN;
        public double MMT_ClampBTN
        {
            get { return m_MMT_ClampBTN; }
            set
            {
                if (m_MMT_ClampBTN != value)
                {
                    m_MMT_ClampBTN = value;
                    RaisePropertyChanged(() => MMT_ClampBTN);
                }
            }
        }
        private double m_MMT_In_Mag;
        public double MMT_In_Mag
        {
            get { return m_MMT_In_Mag; }
            set
            {
                if (m_MMT_In_Mag != value)
                {
                    m_MMT_In_Mag = value;
                    RaisePropertyChanged(() => MMT_In_Mag);
                }
            }
        }
        private double m_MMT_ClampTimeOut;
        public double MMT_ClampTimeOut
        {
            get { return m_MMT_ClampTimeOut; }
            set
            {
                if (m_MMT_ClampTimeOut != value)
                {
                    m_MMT_ClampTimeOut = value;
                    RaisePropertyChanged(() => MMT_ClampTimeOut);
                }
            }
        }
        private double m_MMT_ClampFin;
        public double MMT_ClampFin
        {
            get { return m_MMT_ClampFin; }
            set
            {
                if (m_MMT_ClampFin != value)
                {
                    m_MMT_ClampFin = value;
                    RaisePropertyChanged(() => MMT_ClampFin);
                }
            }
        }
    }
}
