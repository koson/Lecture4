using System;

namespace DoorControl {

    public interface IUserValidation {
        public bool ValidateEntryRequest(int id);
    }

}
