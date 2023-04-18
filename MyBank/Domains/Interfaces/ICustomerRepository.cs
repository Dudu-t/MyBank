using MyBank.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domains.Interfaces
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();
        public Customer GetById(int id);
        public Customer GetByCpf(string cpf);
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
    }
}
