using System;

namespace DoorControl {

    public class StubUserValidation : IUserValidation {
        private bool allowAll;

	public StubUserValidation(bool allowAll) {
            this.allowAll = allowAll;
        }

	public bool ValidateEntryRequest(int id) {
            return allowAll;
        }
    }
}
