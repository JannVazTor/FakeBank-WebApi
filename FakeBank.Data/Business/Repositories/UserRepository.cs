using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Repositories
{
    public class UserRepository : Repository<AspNetUser>
    {
        public UserRepository(FAKE_BANKEntities context):base(context)
        {
        }
    }
}
