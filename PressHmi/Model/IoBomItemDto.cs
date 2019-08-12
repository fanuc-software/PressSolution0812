using FanucCnc.Enum;
using GalaSoft.MvvmLight;

namespace PressHmi.Model
{
    public class IoBomItemDto : ViewModelBase
    {

        private PmcAdrTypeEnum m_AdrType;
        public PmcAdrTypeEnum AdrType
        {
            get { return m_AdrType; }
            set
            {
                if (m_AdrType != value)
                {
                    m_AdrType = value;
                    RaisePropertyChanged(() => AdrType);
                }
            }
        }

        private ushort m_Adr;
        public ushort Adr
        {
            get { return m_Adr; }
            set
            {
                if (m_Adr != value)
                {
                    m_Adr = value;
                    RaisePropertyChanged(() => Adr);
                }
            }
        }

        private ushort m_Bit;
        public ushort Bit
        {
            get { return m_Bit; }
            set
            {
                if (m_Bit != value)
                {
                    m_Bit = value;
                    RaisePropertyChanged(() => Bit);
                }
            }
        }

        private string m_Descrip;
        public string Descrip
        {
            get { return m_Descrip; }
            set
            {
                if (m_Descrip != value)
                {
                    m_Descrip = value;
                    RaisePropertyChanged(() => Descrip);
                }
            }
        }

        public string AdrStr
        {
            get
            {
                return m_AdrType.ToString() + Adr + "." + Bit;
            }
        }

        private bool m_Value;
        public bool Value
        {
            get { return m_Value; }
            set
            {
                if (m_Value != value)
                {
                    m_Value = value;
                    RaisePropertyChanged(() => Value);
                }
            }
        }

    }
}
