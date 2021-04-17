using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Entities
{
    public class CustomerType : IEntity
    {
        public CustomerType()
        {
            Customers = new HashSet<Customer>();
        }
        public Guid Id { get; set; }
        public string CustomerTypeName { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
