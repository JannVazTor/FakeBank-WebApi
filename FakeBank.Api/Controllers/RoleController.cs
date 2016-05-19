using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FakeBank.Api.Models;
using FakeBank.Data.Business.Services;
using FakeBank.Data.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FakeBank.Api.Controllers
{
    [RoutePrefix("api/Role")]
    public class RoleController : ApiController
    {
        private readonly FAKE_BANKEntities _db = new FAKE_BANKEntities();
        [HttpPost]
        public IHttpActionResult SaveRol(RoleBindingModel model)
        {
            if (!ModelState.IsValid) return BadRequest();
            var roleService = new RoleService();
            var saved = roleService.Save(new AspNetRole
            {
                Id = model.Id,
                Name = model.Name
            });
            if (!saved) return InternalServerError();
            return Ok();
        }

        [HttpDelete]
        [Route("{roleId}")]
        [Authorize(Roles = "employee")]
        public IHttpActionResult DeleteRole(string roleId)
        {
            if (!ModelState.IsValid) return BadRequest();
            var roleService = new RoleService();
            var role = roleService.GetById(roleId);
            var deleted = roleService.Delete(role);
            if (!deleted) return InternalServerError();
            return Ok();
        }

        [HttpPost]
        [Route("addUserToRole")]
        public IHttpActionResult AddUserToRole(AddRoleToUserBindingModel model)
        {
            try
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_db));
                var user = userManager.FindByName(model.UserName);
                var result = userManager.AddToRole(user.Id, model.RoleName);
                return (result.Succeeded) ? (IHttpActionResult)Ok() : InternalServerError();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
