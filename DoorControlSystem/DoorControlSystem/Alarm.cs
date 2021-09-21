using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    public class Alarm:IAlarm
    {
        public bool alarmSounding { get; private set; }
        public Alarm() { }
        
        public void RaiseAlarm()
        {
            alarmSounding = true;
            Console.WriteLine("DINGELING ALARM IS GOING OFF!!!!!!");
        }
    }

    public class FakeAlarm : IAlarm
    {
        public bool alarmSounding { get; private set; }
        public FakeAlarm(bool alarm) 
        {
            alarmSounding = alarm;
        }

        public void RaiseAlarm()
        {
            alarmSounding = true;
            Console.WriteLine("DINGELING ALARM IS GOING OFF!!!!!!");
        }
    }

    public interface IAlarm
    {
        public void RaiseAlarm();
        bool alarmSounding { get; set; }
    }
}
