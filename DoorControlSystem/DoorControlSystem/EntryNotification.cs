using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    public class EntryNotification:IEntryNotification
    {
        public List<string> records { get; private set; }
        public EntryNotification() 
        {
            records = new();
        }
        public void NotifyEntryGranted(int id)
        {
            records.Add("Access granted to id: " + id);
            Console.WriteLine("Access granted to id: " + id);
        }
        public void NotifyEntryDenied(int id)
        {
            records.Add("Access denied to id: " + id);
            Console.WriteLine("Access denied to id: " + id);
        }
    }

    public class MockEntryNotification : IEntryNotification
    {
        public List<string> records { get; set; }
        public MockEntryNotification()
        {
            records = new();
        }
        public void NotifyEntryGranted(int id)
        {
            records.Add("Access granted to id: " + id);
            Console.WriteLine("Access granted to id: " + id);
        }
        public void NotifyEntryDenied(int id)
        {
            records.Add("Access denied to id: " + id);
            Console.WriteLine("Access denied to id: " + id);
        }
    }

    public interface IEntryNotification
    {
        public void NotifyEntryGranted(int id);
        public void NotifyEntryDenied(int id);
    }
}
