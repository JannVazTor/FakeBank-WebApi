using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Business.Repositories;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Services
{
    public class AccountTypeService:IService<AccountType>
    {
        public bool Save(AccountType accountType)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var accountTypeRepository = new AccountTypeRepository(db);
                    db.AccountTypes.Attach(accountType);
                    accountTypeRepository.Insert(accountType);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(AccountType accountType)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var accountTypeRepository = new AccountTypeRepository(db);
                    accountTypeRepository.Delete(accountType);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountType GetById(Guid id)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var accountTypeRepository = new AccountTypeRepository(db);
                    var accountType = accountTypeRepository.GetById(id);
                    return accountType;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
