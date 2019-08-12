using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace PressHmi.Model
{
    public class MaintainServoInfoDto : ViewModelBase
    {
        private double m_Servo1_Load;

        public double Servo1_Load
        {
            get { return m_Servo1_Load; }
            set
            {
                if (m_Servo1_Load != value)
                {
                    m_Servo1_Load = value;
                    RaisePropertyChanged(() => Servo1_Load);
                }

            }
        }

        private double m_Servo1_Temp;

        public double Servo1_Temp
        {
            get { return m_Servo1_Temp; }
            set
            {
                if (m_Servo1_Temp != value)
                {
                    m_Servo1_Temp = value;
                    RaisePropertyChanged(() => Servo1_Temp);
                }

            }
        }
        private double m_Servo1_Current;

        public double Servo1_Current
        {
            get { return m_Servo1_Current; }
            set
            {
                if (m_Servo1_Current != value)
                {
                    m_Servo1_Current = value;
                    RaisePropertyChanged(() => Servo1_Current);
                }

            }
        }

        private double m_Servo1_Gain;

        public double Servo1_Gain
        {
            get { return m_Servo1_Gain; }
            set
            {
                if (m_Servo1_Gain != value)
                {
                    m_Servo1_Gain = value;
                    RaisePropertyChanged(() => Servo1_Gain);
                }

            }
        }

        private double m_Servo1_PosError;

        public double Servo1_PosError
        {
            get { return m_Servo1_PosError; }
            set
            {
                if (m_Servo1_PosError != value)
                {
                    m_Servo1_PosError = value;
                    RaisePropertyChanged(() => Servo1_PosError);
                }

            }
        }

        private double m_Servo1_Speed;

        public double Servo1_Speed
        {
            get { return m_Servo1_Speed; }
            set
            {
                if (m_Servo1_Speed != value)
                {
                    m_Servo1_Speed = value;
                    RaisePropertyChanged(() => Servo1_Speed);
                }

            }
        }

        private double m_Servo2_Load;

        public double Servo2_Load
        {
            get { return m_Servo2_Load; }
            set
            {
                if (m_Servo2_Load != value)
                {
                    m_Servo2_Load = value;
                    RaisePropertyChanged(() => Servo2_Load);
                }

            }
        }

        private double m_Servo2_Temp;

        public double Servo2_Temp
        {
            get { return m_Servo2_Temp; }
            set
            {
                if (m_Servo2_Temp != value)
                {
                    m_Servo2_Temp = value;
                    RaisePropertyChanged(() => Servo2_Temp);
                }

            }
        }
        private double m_Servo2_Current;

        public double Servo2_Current
        {
            get { return m_Servo2_Current; }
            set
            {
                if (m_Servo2_Current != value)
                {
                    m_Servo2_Current = value;
                    RaisePropertyChanged(() => Servo2_Current);
                }

            }
        }

        private double m_Servo2_Gain;

        public double Servo2_Gain
        {
            get { return m_Servo2_Gain; }
            set
            {
                if (m_Servo2_Gain != value)
                {
                    m_Servo2_Gain = value;
                    RaisePropertyChanged(() => Servo2_Gain);
                }

            }
        }

        private double m_Servo2_PosError;

        public double Servo2_PosError
        {
            get { return m_Servo2_PosError; }
            set
            {
                if (m_Servo2_PosError != value)
                {
                    m_Servo2_PosError = value;
                    RaisePropertyChanged(() => Servo2_PosError);
                }

            }
        }

        private double m_Servo2_Speed;

        public double Servo2_Speed
        {
            get { return m_Servo2_Speed; }
            set
            {
                if (m_Servo2_Speed != value)
                {
                    m_Servo2_Speed = value;
                    RaisePropertyChanged(() => Servo2_Speed);
                }

            }
        }

        private double m_Servo3_Load;

        public double Servo3_Load
        {
            get { return m_Servo3_Load; }
            set
            {
                if (m_Servo3_Load != value)
                {
                    m_Servo3_Load = value;
                    RaisePropertyChanged(() => Servo3_Load);
                }

            }
        }

        private double m_Servo3_Temp;

        public double Servo3_Temp
        {
            get { return m_Servo3_Temp; }
            set
            {
                if (m_Servo3_Temp != value)
                {
                    m_Servo3_Temp = value;
                    RaisePropertyChanged(() => Servo3_Temp);
                }

            }
        }
        private double m_Servo3_Current;

        public double Servo3_Current
        {
            get { return m_Servo3_Current; }
            set
            {
                if (m_Servo3_Current != value)
                {
                    m_Servo3_Current = value;
                    RaisePropertyChanged(() => Servo3_Current);
                }

            }
        }

        private double m_Servo3_Gain;

        public double Servo3_Gain
        {
            get { return m_Servo3_Gain; }
            set
            {
                if (m_Servo3_Gain != value)
                {
                    m_Servo3_Gain = value;
                    RaisePropertyChanged(() => Servo3_Gain);
                }

            }
        }

        private double m_Servo3_PosError;

        public double Servo3_PosError
        {
            get { return m_Servo3_PosError; }
            set
            {
                if (m_Servo3_PosError != value)
                {
                    m_Servo3_PosError = value;
                    RaisePropertyChanged(() => Servo3_PosError);
                }

            }
        }

        private double m_Servo3_Speed;

        public double Servo3_Speed
        {
            get { return m_Servo3_Speed; }
            set
            {
                if (m_Servo3_Speed != value)
                {
                    m_Servo3_Speed = value;
                    RaisePropertyChanged(() => Servo3_Speed);
                }

            }
        }
    }
}
