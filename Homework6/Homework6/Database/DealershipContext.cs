using Homework6.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Database
{
    public class DealershipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ST7RLJH;Initial Catalog=Dealership;Integrated Security=True;");
        }
        public DbSet<ActualFeature> ActualFeatures { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<PossibleFeature> PossibleFeatures { get; set; }
    }
}
