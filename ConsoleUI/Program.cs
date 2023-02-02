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
            User user = new User { FirstName = "Mem Robin", LastName = "Çen", Email = "test@gmail.com", Password = "123456" };
            Customer customer = new Customer { UserId = 1, CompanyName = "Kodlama.io" };
            Rental rental = new Rental { CarId = 1002, CustomerId = 1, RentDate = DateTime.Now};

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(user);

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(rental);
            Console.WriteLine(result.Message);
        }

        private static void EfTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car { BrandId = 2, ColorId = 1009, ModelYear = 2020, Description = "Test", DailyPrice = 6000 };
            //carManager.Add(car);
            //carManager.Delete(carManager.GetById(1004));


            Color color = new Color { Name = "Yellow" };

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(color);
            colorManager.Update(new Color { Id = 1006, Name = "RED" });
            Console.WriteLine(colorManager.GetById(1006).Data.Name);

            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Name);
                }
            }

            Console.WriteLine("--Car Details--");
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.CarName + " - " + item.BrandName + " - " + item.ColorName);
            }
        }

        private static void InMemoryTest()
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

            Console.WriteLine(carManager.GetById(4).Data.Description);
            Console.WriteLine(brandManager.GetById(4).Data.Name);
            Console.WriteLine(colorManager.GetById(4).Data.Name);

            Console.WriteLine("-------Cars-------");
            foreach (Car c in carManager.GetAll().Data)
            {
                Console.WriteLine(c.Description);
            }
            Console.WriteLine("-------Cars-------");
        }
    }
}