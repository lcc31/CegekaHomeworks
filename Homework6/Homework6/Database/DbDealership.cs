using Homework6.Entities;
using Homework6.Interfaces;
using Homework6.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6
{
    public class DbDealership
    {
        private readonly IRepository<ActualFeature> actualFeatureRepository;
        private readonly IRepository<Brand> brandRepository;
        private readonly IRepository<Car> carRepository;
        private readonly IRepository<Customer> customerRepository;
        private readonly IRepository<CustomerType> customerTypeRepository;
        private readonly IRepository<Model> modelRepository;
        private readonly IRepository<PossibleFeature> possibleFeatureRepository;

        public DbDealership(
           IRepository<Brand> brandRepository,
           IRepository<Model> modelRepository,
           IRepository<ActualFeature> actualFeatureRepository,
           IRepository<PossibleFeature> possibleFeatureRepository,
           IRepository<Car> carRepository,
           IRepository<CustomerType> customerTypeRepository,
           IRepository<Customer> customerRepository)
        {
            this.brandRepository = brandRepository;
            this.modelRepository = modelRepository;
            this.actualFeatureRepository = actualFeatureRepository;
            this.possibleFeatureRepository = possibleFeatureRepository;
            this.carRepository = carRepository;
            this.customerTypeRepository = customerTypeRepository;
            this.customerRepository = customerRepository;

            InitialiseData();
        }

        private List<Brand> brandsList;
        private List<Model> modelsList;
        private List<ActualFeature> actualFeaturesList;
        private List<PossibleFeature> possibleFeaturesList;
        private List<Car> carsList;
        private List<CustomerType> customerTypesList;
        private List<Customer> customersList;

        public void InitialiseData()
        {
            brandsList = new List<Brand>
        {
                new Brand {Id=Guid.NewGuid(), BrandName = "Dacia" },
                new Brand {Id=Guid.NewGuid(), BrandName = "Audi" },
                new Brand {Id=Guid.NewGuid(), BrandName = "Mercedes" }
        };

            modelsList = new List<Model>
        {
            new Model{Id=Guid.NewGuid(),ModelName = "Duster",  Brand = brandsList.First(x => x.BrandName == "Dacia")},
            new Model{Id=Guid.NewGuid(),ModelName = "Logan", Brand = brandsList.First(x => x.BrandName == "Dacia") },
            new Model{Id=Guid.NewGuid(),ModelName = "A4", Brand = brandsList.First(x => x.BrandName == "Audi") },
            new Model{Id=Guid.NewGuid(),ModelName = "A5", Brand = brandsList.First(x => x.BrandName == "Audi") },
            new Model{Id=Guid.NewGuid(),ModelName = "Class C", Brand = brandsList.First(x => x.BrandName == "Mercedes") },
            new Model{Id=Guid.NewGuid(),ModelName = "Limousine", Brand = brandsList.First(x => x.BrandName == "Mercedes") }
        };

            actualFeaturesList = new List<ActualFeature>
        {
            new ActualFeature
            {
                Id=Guid.NewGuid(),
                Fuel = "Gas",
                Transmission = "Automatic",
                HorsePower = 111,
                ActualPrice = 13000
            },
            new ActualFeature {Id=Guid.NewGuid(), Fuel = "Diesel", Transmission = "Manual", HorsePower = 102, ActualPrice = 9000 },
            new ActualFeature {Id=Guid.NewGuid(), Fuel = "Gas", Transmission = "Automatic", HorsePower = 131, ActualPrice = 23000 },
            new ActualFeature {Id=Guid.NewGuid(), Fuel = "Electric", Transmission = "Automatic", HorsePower = 114, ActualPrice = 44000 },
            new ActualFeature {Id=Guid.NewGuid(), Fuel = "Electric", Transmission = "Automatic", HorsePower = 135, ActualPrice = 55000 },
            new ActualFeature {Id=Guid.NewGuid(), Fuel = "Gas", Transmission = "Automatic", HorsePower = 141, ActualPrice = 86000 }
        };

            possibleFeaturesList = new List<PossibleFeature>
        {
            new PossibleFeature { Id=Guid.NewGuid(),Navigation = true, Camera = false, LeatherSeats = true, PossibleFeaturePrice = 3000 },
            new PossibleFeature { Id=Guid.NewGuid(),Navigation = false, Camera = false, LeatherSeats = true, PossibleFeaturePrice = 2000 },
            new PossibleFeature { Id=Guid.NewGuid(),Navigation = true, Camera = false, LeatherSeats = true, PossibleFeaturePrice = 6000 },
            new PossibleFeature { Id=Guid.NewGuid(),Navigation = true, Camera = true, LeatherSeats = true, PossibleFeaturePrice = 7000 },
            new PossibleFeature { Id=Guid.NewGuid(),Navigation = true, Camera = true, LeatherSeats = true, PossibleFeaturePrice = 15000 },
            new PossibleFeature { Id=Guid.NewGuid(),Navigation = true, Camera = true, LeatherSeats = true, PossibleFeaturePrice = 2000 }
        };

            carsList = new List<Car>
        {
            new Car
            {
                Id=Guid.NewGuid(),
                Model = modelsList.First(x=>x.ModelName=="Duster"),
                DateManufactured = DateTime.Parse("2021-01-11"),
                ActualFeature = actualFeaturesList.ElementAt(0),
                PossibleFeature= possibleFeaturesList.ElementAt(0)
            },
            new Car {Id=Guid.NewGuid(),
                Model=modelsList.First(x=>x.ModelName=="Logan"),
                DateManufactured = DateTime.Parse("2021-01-12"),
                ActualFeature = actualFeaturesList.ElementAt(1),
                PossibleFeature= possibleFeaturesList.ElementAt(1)},
            new Car {Id=Guid.NewGuid(),Model=modelsList.First(x=>x.ModelName=="A4"), DateManufactured = DateTime.Parse("2021-02-13"), ActualFeature = actualFeaturesList.ElementAt(2), PossibleFeature= possibleFeaturesList.ElementAt(2)},
            new Car {Id=Guid.NewGuid(),Model=modelsList.First(x=>x.ModelName=="A5"),DateManufactured = DateTime.Parse("2021-02-14"), ActualFeature = actualFeaturesList.ElementAt(3), PossibleFeature= possibleFeaturesList.ElementAt(3) },
            new Car {Id=Guid.NewGuid(), Model=modelsList.First(x=>x.ModelName=="Class C"), DateManufactured = DateTime.Parse("2021-03-25"), ActualFeature = actualFeaturesList.ElementAt(4), PossibleFeature= possibleFeaturesList.ElementAt(4)},
            new Car{Id=Guid.NewGuid(),Model=modelsList.First(x=>x.ModelName=="Limousine"), DateManufactured = DateTime.Parse("2021-03-26"), ActualFeature = actualFeaturesList.ElementAt(5), PossibleFeature= possibleFeaturesList.ElementAt(5) }
        };

            customerTypesList = new List<CustomerType>
        {
            new CustomerType {Id=Guid.NewGuid(),CustomerTypeName = "Buyer" },
            new CustomerType {Id=Guid.NewGuid(), CustomerTypeName = "PotentialBuyer" }
        };

            customersList = new List<Customer>
        {
            new Customer {
                Id=Guid.NewGuid(),
                FirstName = "Costin",
                LastName = "Lungu",
                CarId = carsList.ElementAt(0).Id,
                DateViewedCar = DateTime.Parse("2021-03-13"),
                DateBoughtCar = DateTime.Parse("2021-03-15"),
                CustomerTypeId= customerTypesList.ElementAt(0).Id
            },
            new Customer {  Id=Guid.NewGuid(), FirstName = "Irina", LastName = "Hagi", CarId = carsList.ElementAt(1).Id , DateViewedCar = DateTime.Parse("2021-03-13"), DateBoughtCar = DateTime.Parse("2021-03-13"), CustomerTypeId= customerTypesList.ElementAt(0).Id
            },
            new Customer { Id=Guid.NewGuid(), FirstName = "Cristian", LastName = "Ciobanu", CarId= carsList.ElementAt(2).Id , DateViewedCar = DateTime.Parse("2021-03-11"),CustomerTypeId= customerTypesList.ElementAt(1).Id}
        };
        }

        public void InsertDatabaseTable()
        {
            //// ---Uncomment all for MongoDb---

            //foreach (Brand brand in brandsList)
            //{
            //    brandRepository.Insert(brand);
            //}
            //foreach (Model model in modelsList)
            //{
            //    modelRepository.Insert(model);
            //}
            //foreach (ActualFeature actualFeature in actualFeaturesList)
            //{
            //    actualFeatureRepository.Insert(actualFeature);
            //}
            //foreach (PossibleFeature possibleFeature in possibleFeaturesList)
            //{
            //    possibleFeatureRepository.Insert(possibleFeature);
            //}

            //// ---Comment previouses for SSMS---
            foreach (Car car in carsList)
            {
                carRepository.Insert(car);
            }
            foreach (CustomerType customerType in customerTypesList)
            {
                customerTypeRepository.Insert(customerType);
            }
            foreach (Customer customer in customersList)
            {
                customerRepository.Insert(customer);
            }
        }

        public void ReadBrands()
        {
            var brands = brandRepository.GetAll();
            Console.WriteLine("All brands in the database: ");
            foreach (var brand in brands)
            {
                Console.WriteLine(
                     "Brand: " + brand.BrandName
                     );
            }
        }

        public void UpdateBrand()
        {
            var brand = brandRepository.GetAll().Where(b => b.BrandName == "Audi").Single();
            brand.BrandName = "Ferrari";
            brandRepository.Update(brand);
        }

        public void DeleteBrand()
        {
            var brand = brandRepository.GetAll().Where(b => b.BrandName == "Mercedes").Single();
            brandRepository.Delete(brand);
        }

    }
}