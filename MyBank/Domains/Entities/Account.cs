using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Domains.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Agency { get; set; }
        public string Number { get; set; }
        public float Balance { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
