using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Repositories
{
    public class AccountTypeRepository:Repository<AccountType>
    {
        public AccountTypeRepository(FAKE_BANKEntities context) : base(context)
        {
        }
    }
}
