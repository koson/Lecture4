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
        public bool _isOpen { get; private set; }
        public Door()
        {
            doorControl = new DoorControl();
        }

        public void Open()
        {
            if (!_isOpen)
            {
                _isOpen = true;
                Console.WriteLine("Door is now open!");
            }
            else
                Console.WriteLine("Door is already open?!?");
        }
        public void Close()
        {
            if (_isOpen)
            {
                _isOpen = false;
                Console.WriteLine("Door is now closed!");
            }
            else
                Console.WriteLine("Door is already closed?!?");
        }
    }
    public class StubDoor:IDoor
    {
        public bool _isOpen { get; private set; }
        public StubDoor()
        {

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
