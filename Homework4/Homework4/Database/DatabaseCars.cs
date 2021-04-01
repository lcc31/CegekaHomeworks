using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework4.Models
{
    public class DatabaseCars
    {
        public static List<EntityCar> Cars = new List<EntityCar>()
        {
            new EntityCar(1, "Dacia", 111, "Duster", new DateTime(2017,11,23),11000),
            new EntityCar(2, "Audi", 122, "A4", new DateTime(2012,02,22), 12000),
            new EntityCar(3, "Mercedes", 133, "Class C", new DateTime(2013,03,13), 13000),
            new EntityCar(4, "Dacia", 114, "Duster", new DateTime(2014,11,23),10400),
            new EntityCar(5, "Audi", 125, "A4", new DateTime(2005,02,22), 2500),
            new EntityCar(6, "Mercedes", 136, "Class C", new DateTime(2016,06,15), 26000),
            new EntityCar(7, "Dacia", 117, "Duster", new DateTime(2017,07,17),17000),
            new EntityCar(8, "Audi", 128, "A4", new DateTime(2018,02,18), 28000),
            new EntityCar(9, "Mercedes", 139, "Class C", new DateTime(2019,03,19), 90000)
        };
    }
}
