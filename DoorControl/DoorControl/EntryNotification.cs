using System;
using System.Collections.Generic;

namespace DoorControl {

    public class EntryNotification : IEntryNotification {
        private Dictionary<int, string> records;

	public EntryNotification() {
            records = new Dictionary<int, string>();
        }

	public EntryNotification(Dictionary<int, string> records) {
            this.records = records;
        }

	public void NotifyEntryGranted(int id) {
            records.Add(id, "Granted");
        }

	public void NotifyEntryDenied(int id) {
            records.Add(id, "Denied");
        }
    }
}
