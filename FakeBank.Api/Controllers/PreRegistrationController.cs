using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FakeBank.Data.Entities;
using FakeBank.Models;
using FakeBank.Data.Business.Repositories;
using FakeBank.Data.Business.Services;
using System.Web.Http.Results;
using FakeBank.Controllers;

namespace FakeBank.Api.Controllers
{
    [RoutePrefix("api/preRegister")]
    public class PreRegistrationController : BaseAPIController
    {
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult PostPreRegistration(PreRegistrationBindingModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var preRegistration = new PreRegistration
            {
                Id = model.Id,
                UserName = model.UserName,
                FirstSurname= model.FirstLastName,
                SecondSurname= model.SecondLastName,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                IdAccountType = model.IdAccounType
            };
            var preRegistrationService = new PreRegistrationService();
            var result = preRegistrationService.Save(preRegistration);
            if (!result) return new InternalServerErrorResult(this);
            return Ok();
        }

        [HttpGet]
        [Authorize(Roles = "employee")]
        public IHttpActionResult GetAllPreRegistrations()
        {
            var preRegistrationService = new PreRegistrationService();
            var preRegistrations = preRegistrationService.GetAll();
            return Ok(TheModelFactory.Create(preRegistrations));
        }
    }
}
