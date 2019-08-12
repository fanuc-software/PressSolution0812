using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class MaintainTravelInfo
    {
        public double MTO_ServoReady { get; set; }
        public double MTO_BL { get; set; }
        public double MTO_Lubrication { get; set; }
        public double MTO_AirPress { get; set; }
        public double MTO_PE { get; set; }
        public double MTO_EMG { get; set; }
        public double MTO_SafeCock { get; set; }
        public double MTO_TableClamp { get; set; }
        public double MTO_DieClamp { get; set; }
        public double MTO_SafeDoorClose { get; set; }
        public double MTO_Counter { get; set; }
        public double MTO_JOG { get; set; }
        public double MTO_JOGOK { get; set; }
        public double MTO_UpDieCenter { get; set; }
        public double MTO_Single { get; set; }
        public double MTO_SingleOK { get; set; }
        public double MTO_Continue { get; set; }
        public double MTO_ContinueOK { get; set; }
    }
}
