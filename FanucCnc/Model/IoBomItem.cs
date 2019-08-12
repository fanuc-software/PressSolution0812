using FanucCnc.Enum;

namespace FanucCnc.Model
{
    public class IoBomItem
    {
        public PmcAdrTypeEnum AdrType { get; set; }

        public ushort Adr { get; set; }

        public ushort Bit { get; set; }

        public string Descrip { get; set; }

        public bool Value { get; set; }

    }
}
