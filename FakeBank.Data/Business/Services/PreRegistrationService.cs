using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Entities;
using FakeBank.Data.Business.Repositories;

namespace FakeBank.Data.Business.Services
{
    public class PreRegistrationService:IService<PreRegistration>
    {
        public bool Save(PreRegistration preRegister) {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var preRegisterRepository = new PreRegistrationRepository(db);
                    db.PreRegistrations.Attach(preRegister);
                    preRegisterRepository.Insert(preRegister);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(PreRegistration preRegister) {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var preRegisterRepository = new PreRegistrationRepository(db);
                    preRegisterRepository.Delete(preRegister);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
