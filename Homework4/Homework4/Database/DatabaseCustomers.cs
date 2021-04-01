using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class DatabaseCustomers
    {
        public static List<EntityCustomer> Customers = new List<EntityCustomer>
          {
            new EntityCustomer(1,"Ion","Marin"),
            new EntityCustomer(2,"Luca","Popescu"),
            new EntityCustomer(3,"Ionut","Ionescu"),
            new EntityCustomer(4,"Ovidiu","Cisteanu"),
            new EntityCustomer(5,"Andreea","Marin"),
            new EntityCustomer(6,"Ciprian","Ioan"),
            new EntityCustomer(7,"Andrei","Popescu")
        };
    }
}
