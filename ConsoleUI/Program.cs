
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araba Markaları:\n");
            BrandGetAll();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Renkler:\n");
            ColorGetAll();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Araba Detayları:\n");
            GetCarDetailsTest();
            
            Console.WriteLine("-------------------------");
            Console.WriteLine("Kiralanmış Araba Detayları:\n");
            GetRentalDetailsTest();

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result = rentalManager.Add(new Rental {CarId=1,CustomerId=2});
            //if (result.Success)
            //{
            //    Console.WriteLine(result.Message);
                
                
            //}
            //Console.WriteLine(result.Message);
        }

        private static void GetRentalDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetailsDto(1);

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + " / " + rental.CarName + " / " + rental.CustomerName + " / " + rental.RentDate + " / " + rental.ReturnDate);
                }

            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car { ColorId = 5, BrandId = 2002, ModelYear = 2018, DailyPrice = 450, Description = "Otomatik sedan" });
            if (result.Success)
            {
                Console.WriteLine(result.Message + "\n");

                GetCarDetailsTest();
            }
            else
            {
                Console.WriteLine(result.Message + "\n");

                GetCarDetailsTest();
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.Add(new Brand { BrandName = "m" });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
                BrandGetAll();
            }
            else
            {
                Console.WriteLine(result.Message);
                BrandGetAll();
            }
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName+ " / "+car.CarName+ " / "+car.ColorName + " / "+car.ModelYear+" / " + car.Description);
                }

            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
