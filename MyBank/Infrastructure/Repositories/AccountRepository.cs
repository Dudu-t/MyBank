using MyBank.Domains.Entities;
using MyBank.Domains.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IAccountRepository _accountRepository;

        public AccountRepository(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void Add(Account account)
        {
            throw new NotImplementedException();
        }

        public void Delete(Account account)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetByAgencyAndNumber(int agency, int number)
        {
            throw new NotImplementedException();
        }

        public Account GetByCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
