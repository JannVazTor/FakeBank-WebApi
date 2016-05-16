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

namespace FakeBank.Api.Controllers
{
    [RoutePrefix("api/preRegister")]
    public class PreRegistrationController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostPreRegistration(PreRegistrationBindingModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var preRegistration = new PreRegistration
            {
                id = model.id,
                username = model.username,
                firstLastName = model.firstLastName,
                secondLastName = model.secondLastName,
                phoneNumber = model.phoneNumber,
                email = model.email
            };
            var preRegistrationService = new PreRegistrationService();
            var result = preRegistrationService.Save(preRegistration);
            if (!result) return new InternalServerErrorResult(this);
            return Ok();
        }
    }
}
