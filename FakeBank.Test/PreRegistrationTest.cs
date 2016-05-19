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
                Id = Guid.NewGuid(),
                UserName = "userName",
                FirstSurname= "firstlastname",
                SecondSurname= "secondlastname",
                PhoneNumber = "12312312312",
                Email = "email@gmail.com"
            };
            var preRegistrationService = new PreRegistrationService();
            var result = preRegistrationService.Save(preRegistration);
            Assert.AreEqual(true, result);
        }
    }
}
