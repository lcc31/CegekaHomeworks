using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class LinksCars
    {
        public List<Link> Links = new List<Link>();
        public void DisplayCarLinks()
        {
            Links.Add(new Link("api/cars/", "Get", "Get_All_Cars"));
            Links.Add(new Link("api/cars/{manufacturer}", "Get", "Get_Cars_By_Manufacturer"));
            Links.Add(new Link("api/cars/", "Post", "Insert_Car"));
            Links.Add(new Link("api/cars/{id}", "Put", "Update_Car"));
            Links.Add(new Link("api/cars/{id}", "Delete", "Remove_Car"));
        }
    }
}
