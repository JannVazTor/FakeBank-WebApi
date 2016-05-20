using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeBank.Data.Business.Repositories;
using FakeBank.Data.Entities;

namespace FakeBank.Data.Business.Services
{
    public class CardService:IService<Card>
    {
        public bool Save(Card card)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var cardRepository = new CardRepository(db);
                    db.Cards.Attach(card);
                    cardRepository.Insert(card);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Card card) 
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var cardRepository = new CardRepository(db);
                    cardRepository.Delete(card);
                    return db.SaveChanges() >= 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Card GetByCardNumber(string cardNumber)
        {
            try
            {
                using (var db = new FAKE_BANKEntities())
                {
                    var cardRepository = new CardRepository(db);
                    return cardRepository.SearchOne(c => c.CardNumber.Equals(cardNumber));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Card GetByAccountId(string id)
        {
            try
            {
                var Id = Guid.Parse(id);
                using (var db = new FAKE_BANKEntities())
                {
                    var cardRepository = new CardRepository(db);
                    return cardRepository.SearchOne(c => c.Id == Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
