using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;
using Core.Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();
            if (result.Success == true)
            {
                foreach (var cars in rentalManager.GetRentalDetails().Data)
                {
                    Console.WriteLine("Marka: " + cars.RentalId + "\nModel: " + cars.BrandName + "\nRenk: " + cars.CustomerName + "\nAraç Özellikleri: " + cars.RentDate + "\nAraç Fiyatı: " + cars.ReturnDate);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //CarManager carManager = new(new EfCarDal());

            //AddCarMethod();
            //DeleteCarMethod(carManager);
            //CarUpdateMethod(carManager);
            //GetCarListMethod(carManager);

            //AddUserMethod();

            //AddCustomerMethod();

            //customerManager.GetAll();
            /*
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental1 = new Rental();
            rental1.CarId = 9;
            rental1.CustomerId = 3;
            rental1.RentDate = new DateTime(2021, 07, 19);
            rental1.ReturnDate = new DateTime(2021, 07, 25);

            var result = rentalManager.Add(rental1);

            Console.WriteLine(result.Message);
            */
        }

        /*
        private static void AddCustomerMethod()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                UserId = 1,
                CompanyName = "KodlamaIO"
            });
        }

        private static void AddUserMethod()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Soner",
                LastName = "Çelik",
                Email = "snrclk94@outlook.com",
                Password = "soner1903"
            });
        }

        private static void GetCarListMethod(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var cars in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine("Marka: " + cars.BrandName + "\nModel: " + cars.ModelName + "\nRenk: " + cars.ColorName + "\nAraç Özellikleri: " + cars.Description + "\nAraç Fiyatı: " + cars.DailyPrice + "\nModel Yılı: " + cars.ModelYear);
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
            var result = carManager.GetById(5);

            if (result.Success == true)
            {
                var carDetail = carManager.GetById(5).Data;
                carDetail.ModelName = "Ford";
                carDetail.BrandId = 18;
                carDetail.ColorId = 3;
                carDetail.DailyPrice = 120;
                carDetail.Description = "Dizel, Otomatik";
                carManager.Update(carDetail);
                Console.WriteLine(result.Message);
            }
        }

        private static void DeleteCarMethod(CarManager carManager)
        {
            var result = carManager.GetById(5);
            Console.WriteLine(result);
            var carDetail = carManager.GetById(5).Data;
            carManager.Delete(carDetail);
            Console.WriteLine(result.Success);
        }

        private static void AddCarMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                ModelName = "Megane",
                ColorId = 4,
                BrandId = 2,
                DailyPrice = 150,
                Description = "Dizel, Otomatik",
                ModelYear = 2013
            });
        }
        */
    }
}