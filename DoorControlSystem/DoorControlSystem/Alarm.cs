using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    class Alarm:IAlarm
    {
        private bool _isOn { get; set; }
        public Alarm() { }

        public void RaiseAlarm()
        {
            if (!_isOn)
            {
                _isOn = true;
                Console.WriteLine("Alarm has been raised!");
            }
            else
                Console.WriteLine("Alarm is already raised?!?");

        }
        public void LowerAlarm()
        {
            if (_isOn)
            {
                _isOn = false;
                Console.WriteLine("Alarm has been lowered!");
            }
            else
                Console.WriteLine("Alarm is already lowered?!?");
        }
        public void SoundAlarm()
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
        public void LowerAlarm();
        public void SoundAlarm();
        public bool RunSelfTest();

    }
}
