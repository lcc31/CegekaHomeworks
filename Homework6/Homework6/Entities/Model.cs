using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Entities
{
    public class Model : IEntity
    {
        public Model()
        {
            Cars = new HashSet<Car>();
        }

        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public string ModelName { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Car> Cars{ get; set; }
    }
}
