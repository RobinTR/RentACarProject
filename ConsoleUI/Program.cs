using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Brand brand = new Brand() { Id = 4, Name = "Chevrolet" };
            Color color = new Color() { Id = 4, Name = "Green"};
            Car car = new Car() { Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 5000, Description = "Test 4", ModelYear = 2023 };

            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            brandManager.Add(brand);

            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            colorManager.Add(color);

            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(car);

            Console.WriteLine(carManager.GetById(4).Description);
            Console.WriteLine(brandManager.GetById(4).Name);
            Console.WriteLine(colorManager.GetById(4).Name);

            Console.WriteLine("-------Cars-------");
            foreach(Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
            Console.WriteLine("-------Cars-------");
        }
    }
}