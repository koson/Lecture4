using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    class Alarm : IAlarm
    {
        public bool isAlarmed { get; private set; } = false;
        public void RaiseAlarm()
        {
            
        }
    }
}
