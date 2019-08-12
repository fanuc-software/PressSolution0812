using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc.Model
{
    public class MaintainIoInfo
    {
        public ObservableCollection<IoBomItem> InputBom = new ObservableCollection<IoBomItem>();

        public ObservableCollection<IoBomItem> OutputBom = new ObservableCollection<IoBomItem>();
    }
}
