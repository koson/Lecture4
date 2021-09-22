using NUnit.Framework;
using DoorControlSystem;

namespace DoorControlSystem.Unittests
{
    public class DoorTests
    {
        StubDoor door;

        [TestCase(false,false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(true, true)]
        public void Door_DoorState(bool startState, bool doorAction)
        {
            if (startState)

                door = new StubDoor(true);
            else
                door = new StubDoor(false);

            if (doorAction)
            {
                door.Open();
                Assert.IsTrue(door._isOpen);
            }
            else
            {
                door.Close();
                Assert.IsFalse(door._isOpen);
            }
        }
    }
}