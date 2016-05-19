using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Repositories
{
    public class TransactionRepository:Repository<Transaction>
    {
        public TransactionRepository(FAKE_BANKEntities context) : base(context)
        {

        }
    }
}
