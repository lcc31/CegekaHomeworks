using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Entities
{
    public class PossibleFeature : IEntity
    {
        public PossibleFeature()
        {
            Cars = new HashSet<Car>();
        }
        public Guid Id { get; set; }
        public bool? Navigation { get; set; }
        public bool? Camera { get; set; }
        public bool? LeatherSeats { get; set; }
        public int PossibleFeaturePrice { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
