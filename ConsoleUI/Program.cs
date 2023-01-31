using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(1).Description);

            Car car = new Car() { BrandId = 3, ColorId = 3 , Description = "a"};
            Car car2 = new Car { BrandId = 3, ColorId = 3, ModelYear = 2023, Description = "XC60", DailyPrice = 10000};
            //carManager.Add(car);//Hata verir geçersiz iş kuralı.
            //carManager.Add(car2);//Sorunsuz eklendi veri tabanına.

            Color color = new Color { Name = "Gray"};

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(color);
            Console.WriteLine(colorManager.GetById(5).Name);
        }

        /*private static void InMemoryTest()
        {
            Brand brand = new Brand() { Id = 4, Name = "Chevrolet" };
            Color color = new Color() { Id = 4, Name = "Green" };
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
            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
            Console.WriteLine("-------Cars-------");
        }*/
    }
}