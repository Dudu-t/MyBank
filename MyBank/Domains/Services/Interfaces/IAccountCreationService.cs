using MyBank.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domains.Services.Interfaces
{
    public interface IAccountCreationService
    {
        public void CreateAccount(string agency, string Number, string initialBalance, ICollection<Customer> customers);
    }
}
