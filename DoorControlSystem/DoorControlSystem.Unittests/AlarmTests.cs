using NUnit.Framework;
using DoorControlSystem;

namespace DoorControlSystem.Unittests
{    
    public class AlarmTests
    {
        Alarm alarm;
        FakeAlarm fakeAlarm;
        [SetUp]
        public void Setup()
        {
            
        }

        [TestCase]
        public void Alarm_AlarmIsSounding_ReturnTrue()
        {
            alarm = new Alarm();
            alarm.RaiseAlarm();
            Assert.IsTrue(alarm.alarmSounding);
        }
    }
}