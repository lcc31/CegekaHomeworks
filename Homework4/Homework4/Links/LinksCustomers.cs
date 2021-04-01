using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class LinksCustomers
    {
        public List<Link> Links = new List<Link>();
        public void DisplayCustomersLinks()
        {
            Links.Add(new Link("api/customers/", "Get", "Get_All_Customers"));
            Links.Add(new Link("api/customers/{LastName}", "Get", "Get_Customers_By_Lastname"));
            Links.Add(new Link("api/customers/", "Post", "Insert_Customer"));
            Links.Add(new Link("api/customers/{id}", "Put", "Update_Customer"));
            Links.Add(new Link("api/customers/{id}", "Delete", "Remove_Customer"));
        }
    }
}
