using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class ParaHydrDieCushionInfoDto : ViewModelBase
    {
        private double m_StartPos_1;
        public double StartPos_1
        {
            get { return m_StartPos_1; }
            set
            {
                if (m_StartPos_1 != value)
                {
                    m_StartPos_1 = value;
                    RaisePropertyChanged(() => StartPos_1);
                }
            }
        }

        public string StrStartPos_1
        {
            get
            {
                return StartPos_1.ToString("0.00");
            }
        }

        private double m_StartArr_1;
        public double StartArr_1
        {
            get { return m_StartArr_1; }
            set
            {
                if (m_StartArr_1 != value)
                {
                    m_StartArr_1 = value;
                    RaisePropertyChanged(() => StartArr_1);
                }
            }
        }

        private double m_EndPos_1;
        public double EndPos_1
        {
            get { return m_EndPos_1; }
            set
            {
                if (m_EndPos_1 != value)
                {
                    m_EndPos_1 = value;
                    RaisePropertyChanged(() => EndPos_1);
                }
            }
        }

        public string StrEndPos_1
        {
            get
            {
                return EndPos_1.ToString("0.00");
            }
        }

        private double m_EndArr_1;
        public double EndArr_1
        {
            get { return m_EndArr_1; }
            set
            {
                if (m_EndArr_1 != value)
                {
                    m_EndArr_1 = value;
                    RaisePropertyChanged(() => EndArr_1);
                }
            }
        }

        private double m_ActionFlag_1;
        public double ActionFlag_1
        {
            get { return m_ActionFlag_1; }
            set
            {
                if (m_ActionFlag_1 != value)
                {
                    m_ActionFlag_1 = value;
                    RaisePropertyChanged(() => ActionFlag_1);
                }
            }
        }

        private double m_Enable_1;
        public double Enable_1
        {
            get { return m_Enable_1; }
            set
            {
                if (m_Enable_1 != value)
                {
                    m_Enable_1 = value;
                    RaisePropertyChanged(() => Enable_1);
                }
            }
        }

        private double m_StartPos_2;
        public double StartPos_2
        {
            get { return m_StartPos_2; }
            set
            {
                if (m_StartPos_2 != value)
                {
                    m_StartPos_2 = value;
                    RaisePropertyChanged(() => StartPos_2);
                }
            }
        }

        public string StrStartPos_2
        {
            get
            {
                return StartPos_2.ToString("0.00");
            }
        }


        private double m_StartArr_2;
        public double StartArr_2
        {
            get { return m_StartArr_2; }
            set
            {
                if (m_StartArr_2 != value)
                {
                    m_StartArr_2 = value;
                    RaisePropertyChanged(() => StartArr_2);
                }
            }
        }

        private double m_EndPos_2;
        public double EndPos_2
        {
            get { return m_EndPos_2; }
            set
            {
                if (m_EndPos_2 != value)
                {
                    m_EndPos_2 = value;
                    RaisePropertyChanged(() => EndPos_2);
                }
            }
        }

        public string StrEndPos_2
        {
            get
            {
                return EndPos_2.ToString("0.00");
            }
        }

        private double m_EndArr_2;
        public double EndArr_2
        {
            get { return m_EndArr_2; }
            set
            {
                if (m_EndArr_2 != value)
                {
                    m_EndArr_2 = value;
                    RaisePropertyChanged(() => EndArr_2);
                }
            }
        }

        private double m_ActionFlag_2;
        public double ActionFlag_2
        {
            get { return m_ActionFlag_2; }
            set
            {
                if (m_ActionFlag_2 != value)
                {
                    m_ActionFlag_2 = value;
                    RaisePropertyChanged(() => ActionFlag_2);
                }
            }
        }


        private double m_Enable_2;
        public double Enable_2
        {
            get { return m_Enable_2; }
            set
            {
                if (m_Enable_2 != value)
                {
                    m_Enable_2 = value;
                    RaisePropertyChanged(() => Enable_2);
                }
            }
        }

    }
}
