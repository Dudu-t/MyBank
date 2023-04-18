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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MyBankContext _bankContext;

        public CustomerRepository(MyBankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public void Add(Customer customer)
        {
            _bankContext.Add(customer);
            _bankContext.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            _bankContext.Remove(customer);
            _bankContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _bankContext.Customers;
        }

        public Customer GetByCpf(string cpf)
        {
            return _bankContext.Customers.Where((customer) => customer.Cpf == cpf).First();
        }
        public Customer GetById(int id)
        {
            return _bankContext.Customers.Where((customer) => customer.Id == id).First();
        }

        public void Update(Customer customer)
        {
            _bankContext.Customers.Update(customer);
            _bankContext.SaveChanges();

        }
    }
}
