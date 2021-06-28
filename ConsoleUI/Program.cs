using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                CarName = "Renault",
                ColorId = 3,
                BrandId = 4,
                DailyPrice = 150,
                Description = "Gasoline, Manual",
                ModelYear = 2015
            });


            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarName);
            }
        }
    }
}
