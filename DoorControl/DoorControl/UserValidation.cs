using System;
using System.Collections.Generic;

namespace DoorControl {

    public class UserValidation : IUserValidation {
        public HashSet<int> authorizedUserIds { get; private set; } = new HashSet<int>();

	public bool ValidateEntryRequest(int id) {
            return authorizedUserIds.Contains(id);
        }
    }
}
