using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    class Door:IDoor
    {
        IDoorControl doorControl;
        private bool _isOpen { get; set; }
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
        public bool RunSelfTest()
        {
            return true;
        }
    }

    interface IDoor
    {
        public void Open();
        public void Close();
        public bool RunSelfTest();
    }
}
