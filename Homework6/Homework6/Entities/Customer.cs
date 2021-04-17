using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Entities
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid CarId { get; set; }
        public DateTime? DateBoughtCar { get; set; }
        public DateTime DateViewedCar { get; set; }
        public Guid CustomerTypeId { get; set; }
        public virtual Car Car { get; set; }
        public virtual CustomerType CustomerType { get; set; }
    }
}
