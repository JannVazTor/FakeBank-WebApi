using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Repositories
{
    public class PreRegistrationRepository : Repository<PreRegistration>
    {
        public PreRegistrationRepository(FAKE_BANKEntities context) : base(context) {
        }
    }
}
