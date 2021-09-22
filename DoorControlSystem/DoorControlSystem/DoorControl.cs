using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    enum DoorControlStates
    {
        DoorClosed,
        DoorClosing,
        DoorOpen,
        DoorOpening,
        DoorBreached
    }
    
    public class DoorControl:IDoorControl
    {
        IDoor _door;
        IAlarm _alarm;
        IUserValidation _userValidation;
        IEntryNotification _entryNotification;
        DoorControlStates currentState;
        
        public DoorControl() { }
        public DoorControl(IDoor door, IAlarm alarm, IUserValidation userValidation, IEntryNotification entryNotification)
        {
            _door = door; 
            _alarm = alarm;
            _userValidation = userValidation;
            _entryNotification = entryNotification;
            currentState = DoorControlStates.DoorClosed;
        }
        public void RequestEntry(int id)
        {
            if (_userValidation.ValidateEntryRequest(id))
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted(id);
                currentState = DoorControlStates.DoorOpening;
            }
        }
        public void DoorOpened()
        {
            currentState = DoorControlStates.DoorOpen;
            _door.Close();
        }
        public void DoorClosed()
        {
            currentState = DoorControlStates.DoorClosed;
        }
    }

    interface IDoorControl
    {
        public void RequestEntry(int id);
        public void DoorOpened();
        public void DoorClosed();
    }
}
