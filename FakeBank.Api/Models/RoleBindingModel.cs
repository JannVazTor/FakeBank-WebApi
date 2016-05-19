using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBank.Api.Models
{
    public class RoleBindingModel
    {
            [Required]
            public string Id { get; set; }
            [Required]
            public string Name { get; set; }
    }

    public class AddRoleToUserBindingModel
    {
        [Required]
        public string UserName { get; set; }

        public string RoleName { get; set; }
    }
}