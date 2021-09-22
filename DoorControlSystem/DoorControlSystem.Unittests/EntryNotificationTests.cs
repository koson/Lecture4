using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem.Unittests
{
    class EntryNotificationTests
    {
        MockEntryNotification entryNotification;

        [Test]
        public void EntrNotif_Granted_IsInRecords()
        {
            entryNotification = new MockEntryNotification();
            Assert.IsEmpty(entryNotification.records);

            entryNotification.NotifyEntryGranted(1);
            CollectionAssert.Contains(entryNotification.records, "Access granted to id: 1");
        }

        [Test]
        public void EntrNotif_Denied_IsInRecords()
        {
            entryNotification = new MockEntryNotification();
            Assert.IsEmpty(entryNotification.records);

            entryNotification.NotifyEntryDenied(1);
            CollectionAssert.Contains(entryNotification.records, "Access denied to id: 1");
        }
    }
}
