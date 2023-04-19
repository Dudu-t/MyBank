using MyBank.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domains.Interfaces
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> GetAll();
        public Account GetById(int id);
        public Account GetByAgencyAndNumber(string agency, string number);
        public Account GetByCustomer(Customer customer);
        public void Add(Account account);
        public void Update(Account account);
        public void Delete(Account account);    

    }
}
