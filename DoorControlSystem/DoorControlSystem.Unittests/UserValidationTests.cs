using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoorControlSystem.Unittests
{
    class UserValidationTests
    {
        UserValidation userValidation;

        [Test]
        public void UserVal_UserIdsEmptyOnCreate_ReturnTrue()
        {
            userValidation = new();
            Assert.IsEmpty(userValidation.authorizedUserIds);
        }
        [TestCase(1)]
        [TestCase(529)]
        [TestCase(3313)]
        [TestCase(15)]
        public void UserVal_WhitelistUser_IsInAuthorizedIds(int testId)
        {
            userValidation = new();
            userValidation.WhitelistUserId(testId);
            CollectionAssert.Contains(userValidation.authorizedUserIds, testId);
        }

        [TestCase(1)]
        [TestCase(529)]
        [TestCase(3313)]
        [TestCase(15)]
        public void UserVal_BlacklistUser_IsNotInAuthorizedIds(int testId)
        {
            userValidation = new();
            userValidation.authorizedUserIds.Add(testId);
            CollectionAssert.Contains(userValidation.authorizedUserIds, testId);

            userValidation.BlacklistUserId(testId);
            CollectionAssert.IsEmpty(userValidation.authorizedUserIds);
        }

        [TestCase(1)]
        [TestCase(529)]
        [TestCase(3313)]
        [TestCase(15)]
        public void UserVal_AuthorizeUserIdIsInAuthorized_ReturnsTrue(int testId)
        {
            userValidation = new();
            userValidation.authorizedUserIds.Add(testId);
            CollectionAssert.Contains(userValidation.authorizedUserIds, testId);

            Assert.IsTrue(userValidation.ValidateEntryRequest(testId));
        }

        [TestCase(1)]
        [TestCase(529)]
        [TestCase(3313)]
        [TestCase(15)]
        public void UserVal_AuthorizeUserIdNotInAuthorized_ReturnsFalse(int testId)
        {
            userValidation = new();
            CollectionAssert.IsEmpty(userValidation.authorizedUserIds);

            Assert.IsFalse(userValidation.ValidateEntryRequest(testId));
        }
    }
}
