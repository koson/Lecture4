using System;

namespace DoorControl {

    public class Door : IDoor
    {
        private DoorControl doorControl = null;
        public bool isOpen { get; private set; } = false;

        public Door()
        {

        }

        public Door(DoorControl doorControl)
        {
            setDoorControl(doorControl);
        }

	public void setDoorControl(DoorControl doorControl) {
            this.doorControl = doorControl;
        }

	public void Open() {
            this.isOpen = true;
        }

	public void Close() {
            this.isOpen = false;
        }

    }
}
