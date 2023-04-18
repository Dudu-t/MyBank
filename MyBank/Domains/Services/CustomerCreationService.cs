using MyBank.Domains.Entities;
using MyBank.Domains.Interfaces;
using MyBank.Domains.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domains.Services
{
    public class CustomerCreationService : ICustomerCreationService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerCreationService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void CreateCustomer(string name, string phone, string cpf)
        {

            Customer newCustomer = new Customer
            {
                Name = name,
                Phone = phone,
                Cpf = cpf
            };

            _customerRepository.Add(newCustomer);
        }
    }
}
