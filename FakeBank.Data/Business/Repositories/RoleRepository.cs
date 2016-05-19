using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Repositories
{
    public class RoleRepository: Repository<AspNetRole>
    {
        public RoleRepository(FAKE_BANKEntities context) : base(context)
        {
        }
    }
}
