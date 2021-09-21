using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlSystem
{
    class UserValidation:IUserValidation
    {
        public List<int> authorizedUserIds { get; private set; }
        public UserValidation()
        {

        }
        public bool ValidateEntryRequest(int id)
        {
            for (int i = 0; i < authorizedUserIds.Count; i++)
            {
                if (authorizedUserIds[i] == id)
                    return true;
            }
            return false;
        }

        public void WhitelistUserId(int id)
        {
            for (int i = 0; i < authorizedUserIds.Count; i++)
            {
                if (authorizedUserIds[i] == id)
                {
                    Console.WriteLine("User is already whitelisted!");
                    return;
                }
            }
            authorizedUserIds.Add(id);
        }
        public void BlacklistUserId(int id)
        {
            for (int i = 0; i < authorizedUserIds.Count; i++)
            {
                if (authorizedUserIds[i] == id)
                {
                    authorizedUserIds.RemoveAt(i);
                }
            }
        }
    }

    class StubUserValidation:IUserValidation
    {
        public List<int> authorizedUserIds { get; private set; }
        public StubUserValidation(int id)
        {
            authorizedUserIds.Add(id);
        }
        public bool ValidateEntryRequest(int id)
        {
            for (int i = 0; i < authorizedUserIds.Count; i++)
            {
                if (authorizedUserIds[i] == id)
                    return true;
            }
            return false;
        }

        public void WhitelistUserId(int id)
        {
            for (int i = 0; i < authorizedUserIds.Count; i++)
            {
                if (authorizedUserIds[i] == id)
                {
                    Console.WriteLine("User is already whitelisted!");
                    return;
                }
            }
            authorizedUserIds.Add(id);
        }
        public void BlacklistUserId(int id)
        {
            for (int i = 0; i < authorizedUserIds.Count; i++)
            {
                if (authorizedUserIds[i] == id)
                {
                    authorizedUserIds.RemoveAt(i);
                }
            }
        }
    }

    interface IUserValidation
    {
        public bool ValidateEntryRequest(int id);
        public void WhitelistUserId(int id);
        public void BlacklistUserId(int id);
    }
}
