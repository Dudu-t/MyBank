using MyBank.Domains.Entities;
using MyBank.Domains.Interfaces;
using MyBank.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyBankContext _bankContext;

        public AccountRepository(MyBankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public void Add(Account account)
        {
            _bankContext.Accounts.Add(account);
            _bankContext.SaveChanges();
        }

        public void Delete(Account account)
        {
            _bankContext.Accounts.Remove(account);
            _bankContext.SaveChanges();
        }

        public IEnumerable<Account> GetAll()
        {
            return _bankContext.Accounts;
        }

        public Account GetByAgencyAndNumber(string agency, string number)
        {
            return _bankContext.Accounts.Where(account => account.Agency == agency && account.Number == number).First();
        }

        public Account GetByCustomer(Customer customer)
        {
            return _bankContext.Accounts.Where(account => account.Customers.Contains(customer)).First();
        }

        public Account GetById(int id)
        {
            return _bankContext.Accounts.Where(account => account.Id == id).First();
        }

        public void Update(Account account)
        {
            _bankContext.Update(account);
            _bankContext.SaveChanges();
        }
    }
}
