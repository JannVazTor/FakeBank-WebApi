using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Business.Repositories;
using FakeBank.Data.Entities;
using Microsoft.Win32;

namespace FakeBank.Data.Business.Services
{
    public class UserService
    {
        public AspNetUser GetById(string id)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var userRepository = new UserRepository(db);
                    return userRepository.SearchOne(u => u.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
