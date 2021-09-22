using System;

namespace DoorControlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoor door = new Door();
            IAlarm alarm = new Alarm();
            IUserValidation userValidation = new UserValidation();
            IEntryNotification entryNotification = new EntryNotification();

            IDoorControl doorControl = new DoorControl(door, alarm, userValidation, entryNotification);
            Random r = new();

            userValidation.WhitelistUserId(1);
            userValidation.WhitelistUserId(4);
            userValidation.WhitelistUserId(7);
            userValidation.WhitelistUserId(9);

            for (int i = 0; i < 10; i++)
            {
                int id = r.Next(0, 10);
                doorControl.RequestEntry(id);
            }
        }
    }
}
