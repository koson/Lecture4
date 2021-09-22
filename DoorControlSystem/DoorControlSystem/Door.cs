using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    public class Door:IDoor
    {
        IDoorControl doorControl;
        public bool _isOpen { get; private set; } = false;
        public Door()
        {
            doorControl = new DoorControl();
        }

        public void Open()
        {
            if (!_isOpen)
            {
                _isOpen = true;
                Console.WriteLine("Door is opening...");

                //Code which opens door

                Console.WriteLine("Door is now open!");
                doorControl.DoorOpened();
            }
            else
                Console.WriteLine("Door is already open?!?");
        }
        public void Close()
        {
            if (_isOpen)
            {
                _isOpen = false;
                Console.WriteLine("Door is closing...!");

                // Code which closes door

                Console.WriteLine("Door is now closed!");
                doorControl.DoorClosed();
            }
            else
                Console.WriteLine("Door is already closed?!?");
        }
    }
    public class StubDoor:IDoor
    {
        public bool _isOpen { get; private set; } = false;
        public StubDoor(bool startState)
        {
            _isOpen = startState;
        }
        public void Open()
        {
            _isOpen = true;
        }
        public void Close()
        {
            _isOpen = false;
        }
    }

    public interface IDoor
    {
        public void Open();
        public void Close();
    }
}
