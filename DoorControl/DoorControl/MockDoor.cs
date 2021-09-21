using System;

namespace DoorControl {

    public class MockDoor : IDoor {
        public DoorControl doorControl;
        public bool isOpen { get; private set; } = false;

        public MockDoor() {
        }

	public void Open() {
            this.isOpen = true;
        }

	public void Close() {
            this.isOpen = false;
        }

	public void setDoorControl(DoorControl doorControl) {
            this.doorControl = doorControl;
        }
    }
}
