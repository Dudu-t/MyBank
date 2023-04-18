using MyBank.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domains.Services.Interfaces
{
    public interface ICustomerCreationService
    {
        public void CreateCustomer(string name, string phone, string cpf);

    }
}
