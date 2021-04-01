using System;
using System.Collections.Generic;

namespace Homework4.Models
{
    public class EntityCar
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public int HorsePower { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Price { get; set; }

        public EntityCar(int id, string manufacturer,
            int horsePower, string model, DateTime year, int price)
        {
            Id = id;
            Manufacturer = manufacturer;
            HorsePower = horsePower;
            Model = model;
            Year = year;
            Price = price;
        }

    }
}
