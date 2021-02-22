using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager();

            //BrandManager();
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach(var color in colorManager.GetByColorName("black"))
            {
                Console.WriteLine(color.ColorName);
            }

        }

        private static void BrandManager()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetByBrandName("BMW"))
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
