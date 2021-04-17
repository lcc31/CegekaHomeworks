using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Entities
{
    public class ActualFeature : IEntity
    {
        public ActualFeature()
        {
            Cars = new HashSet<Car>();
        }
        public Guid Id { get; set; }
        public string Fuel { get; set; }
        public string Transmission { get; set; }
        public int HorsePower { get; set; }
        public int ActualPrice { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}
