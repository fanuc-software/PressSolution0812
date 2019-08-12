using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class MaintainDieHighInfo
    {
        public double MDH_SEL { get; set; }
        public double MDH_BL { get; set; }
        public double MDH_SafeCock { get; set; }
        public double MDH_TableClamped { get; set; }
        public double MDH_Emg { get; set; }
        public double MDH_MoveTableAmp { get; set; }
        public double MDH_Manual { get; set; }
        public double MDH_UnLimitDown { get; set; }
        public double MDH_UnLimitUp { get; set; }
        public double MDH_ManualDown { get; set; }
        public double MDH_ManualUp { get; set; }
        public double MDH_Auto { get; set; }
        public double MDH_UpDieCenter { get; set; }
        public double MDH_AutoAllowUp { get; set; }
        public double MDH_AutoAllowDown { get; set; }
        public double MDH_AutoUp { get; set; }
        public double MDH_AutoDown { get; set; }
    }
}
