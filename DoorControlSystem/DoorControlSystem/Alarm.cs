using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    class Alarm:IAlarm
    {
        public Alarm() { }
        
        public void RaiseAlarm()
        {
            Console.WriteLine("DINGELING ALARM IS GOING OFF!!!!!!");
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }

    interface IAlarm
    {
        public void RaiseAlarm();
        public bool RunSelfTest();
    }
}
