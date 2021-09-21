using System;

namespace DoorControl {

    public interface IEntryNotification {
        public void NotifyEntryGranted(int id);
        public void NotifyEntryDenied(int id);
    }
}
