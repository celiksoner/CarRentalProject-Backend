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
            CarManager carManager = new(new EfCarDal());

            //AddCarMethod();
            //DeleteCarMethod(carManager);
            //CarUpdateMethod(carManager);

            //Araç Listesini Getirme Metodu

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var cars in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine("Marka: " + cars.BrandName + "\nModel: " + cars.ModelName + "\nRenk: " + cars.ColorName + "\nAraç Özellikleri: " + cars.Description + "\nAraç Fiyatı: " + cars.DailyPrice);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



        }

        private static void CarUpdateMethod(CarManager carManager)
        {
            foreach (var item in carManager.GetById(5).Data)
            {
                item.ModelName = "Ford";
                item.BrandId = 18;
                item.ColorId = 3;
                item.DailyPrice = 120;
                item.Description = "Dizel, Otomatik";

                carManager.Update(item);
            }
        }

        private static void DeleteCarMethod(CarManager carManager)
        {
            foreach (var item in carManager.GetById(4).Data)
            {
                carManager.Delete(item);
            }
        }

        private static void AddCarMethod()
        {
            CarManager carManager = new(new EfCarDal());
            carManager.Add(new Car
            {
                ModelName = "Renault Clio",
                ColorId = 2,
                BrandId = 2,
                DailyPrice = 100,
                Description = "Benzin, Manuel",
                ModelYear = 2013
            });
        }
    }
}
