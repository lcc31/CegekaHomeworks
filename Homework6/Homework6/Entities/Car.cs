using Homework6.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Entities
{
    public class Car : IEntity
    {
        public Car()
        {
            Customers = new HashSet<Customer>();
        }

        public Guid Id { get; set; }
        public Guid ModelId { get; set; }
        public DateTime DateManufactured { get; set; }
        public Guid ActualFeatureId { get; set; }
        public Guid? PossibleFeatureId { get; set; }
        public virtual Model Model { get; set; }
        public virtual ActualFeature ActualFeature { get; set; }
        public virtual PossibleFeature PossibleFeature { get; set; }
        public virtual ICollection<Customer> Customers{ get; set; }

    }
}
