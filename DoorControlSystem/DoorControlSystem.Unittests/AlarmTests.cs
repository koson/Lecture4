using NUnit.Framework;
using DoorControlSystem;

namespace DoorControlSystem.Unittests
{    
    public class AlarmTests
    {
        Alarm alarm;
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Alarm_AlarmIsSounding_ReturnTrue()
        {
            alarm = new Alarm();
            alarm.RaiseAlarm();
            Assert.IsTrue(alarm.alarmSounding);
        }
        
    }
}