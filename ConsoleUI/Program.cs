
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());



            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("-{0} marka, {1} renk, {2} Tl, {3} model, {4}\n", brandManager.GetById(car.BrandId).BrandName, colorManager.GetById(car.ColorId).ColorName, car.DailyPrice, car.ModelYear, car.Description);
            //}


            //brandManager.Add(new Brand { BrandName="m"});

            

            //Console.WriteLine("Eklemeden sonraki yeni tablo:\n");
            GetCarDetailsTest();
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " -- " + car.Description + " -- " + car.ColorName + " -- " + car.DailyPrice);
            }
        }
    }
}
