using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeBank.Data.Business.Services;
using FakeBank.Data.Entities;
namespace FakeBank.Test
{
    [TestClass]
    public class PreRegistrationTest
    {
        [TestMethod]
        public void PreRegistration()
        {
            var preRegistration = new PreRegistration
            {
                id = Guid.NewGuid(),
                username = "userName",
                firstLastName = "firstlastname",
                secondLastName = "secondlastname",
                phoneNumber = "12312312312",
                email = "email@gmail.com"
            };
            var preRegistrationService = new PreRegistrationService();
            var result = preRegistrationService.Save(preRegistration);
            Assert.AreEqual(true, result);
        }
    }
}
