using Homework6.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Entities
{
    public class Brand : IEntity
    {
        public Brand()
        {
            Models = new HashSet<Model>();
        }

        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
