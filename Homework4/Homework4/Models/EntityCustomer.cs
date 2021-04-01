using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class EntityCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EntityCar> BoughtVehicles { get; set; }

        public EntityCustomer(int id, string firstName,
            string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BoughtVehicles = new List<EntityCar>();
        }

    }
}
