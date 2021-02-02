
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba id: "+ car.CarId);
                Console.WriteLine("Araba model id: "+car.BrandId);
                Console.WriteLine("Araba model id: "+car.ColorId);
                Console.WriteLine("Araba model yılı: "+car.ModelYear);
                Console.WriteLine("Araba günlük kiralama ücreti: "+car.DailyPrice);
                Console.WriteLine("Tanım: "+car.Description);
                Console.WriteLine("------------");
            }
        }
    }
}
