using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace RentalCar
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDetailTest();
            CarTest();


            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result = rentalManager.Add(new Rental { CarId = 2, UserId = 2, CustomerId = 2 });
            //Console.WriteLine(result.Success);
            //Console.WriteLine(result.Message);


            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandId = 3, BrandName = "Land Rover" });




            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorId = 1, ColorName = "Beyaz" });
            //var result = colorManager.GetAll();
            //foreach (var color in result.Data)
            //{
            //    Console.WriteLine(color.ColorId + color.ColorName);
            //}



            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { CustomerId = 3, UserId = 3, CompanyName = "GÖKSAN" });
            //var result = customerManager.GetAll();
            //foreach (var customer in result.Data)
            //{
            //    Console.WriteLine(" {0} --- Şirket İsmi : {1} ", customer.CustomerId, customer.CompanyName);
            //}




            //UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User
            //{
            //    UserId = 2,
            //    FirstName = "Ali",
            //    LastName = "Şahin",
            //    Email = "aliaslan1997@gmail.com",
            //    Password = "aliaslan08.01"
            //});

            //var result = userManager.GetAll();

            //foreach (var user in result.Data)
            //{
            //    Console.WriteLine(user.UserId + " / " + user.FirstName + " / " + user.LastName + " / " + user.Email + " / " +
            //                      user.Password);
            //}






        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.Description + " / " + car.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.DailyPrice);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}