using Homework6.Database;
using Homework6.Entities;
using Homework6.Interfaces;
using Homework6.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------ENTITYFRAMEWORK-------------//

            DbDealership dbDealership = new DbDealership(
                new EFRepository<Brand>(),
                new EFRepository<Model>(),
                new EFRepository<ActualFeature>(),
                new EFRepository<PossibleFeature>(),
                new EFRepository<Car>(),
                new EFRepository<CustomerType>(),
                new EFRepository<Customer>());

            dbDealership.InsertDatabaseTable();
            dbDealership.ReadBrands();
            dbDealership.UpdateBrand();
            dbDealership.DeleteBrand();
            dbDealership.ReadBrands();




            //////--------------MONGOdb-------------//

            //DbDealership dbDealership = new DbDealership(
            // new MongoDbRepository<Brand>(),
            // new MongoDbRepository<Model>(),
            // new MongoDbRepository<ActualFeature>(),
            // new MongoDbRepository<PossibleFeature>(),
            // new MongoDbRepository<Car>(),
            // new MongoDbRepository<CustomerType>(),
            // new MongoDbRepository<Customer>());

            //dbDealership.InsertDatabaseTable();
            //dbDealership.ReadBrands();
            //dbDealership.UpdateBrand();
            //dbDealership.DeleteBrand();
            //dbDealership.ReadBrands();




        }

    }
}
