using MyBank.Domains.Entities;
using MyBank.Domains.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domains.Services
{
    public class AccountCreationService : IAccountCreationService
    {
        public void CreateAccount(string agency, string Number, string initialBalance, ICollection<Customer> customers)
        {
            throw new NotImplementedException();
        }
    }
}
