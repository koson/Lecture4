using NUnit.Framework;
using DoorControlSystem;

namespace DoorControlSystem.Unittests
{    
    public class AlarmTests
    {
        Alarm alarm;

        [Test]
        public void Alarm_RunSelfTest_ReturnTrue()
        {
            alarm = new Alarm();
            Assert.IsTrue(alarm.RunSelfTest());
        }
        
    }
}