using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Business.Repositories;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Services
{
    public class TokenService:IService<Token>
    {
        public bool Save(Token token)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var tokenRepository = new TokenRepository(db);
                    db.Tokens.Attach(token);
                    tokenRepository.Insert(token);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Token token)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var tokenRepository = new TokenRepository(db);
                    tokenRepository.Delete(token);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Token GetById(Guid id)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var tokenRepository = new TokenRepository(db);
                    var token = tokenRepository.GetById(id);
                    return token;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Token GetByToken(Guid token)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var tokenRepository = new TokenRepository(db);
                    return tokenRepository.SearchOne(t => t.Token1 == token);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
