
using Business.Concrete;
using DataAccess.Concrete.EntitiyFrameWork;
using Business.Constant;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager crmngr = new RentalManager(new EfRentalDal());
            var result = crmngr.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.RentDate.Year + "-"+ item.RentDate.Month+ "-" + item.RentDate.Day);
            }
            Console.ReadKey();
        }

        private static void RentalDetailTest()
        {
            RentalManager rtnmgr = new RentalManager(new EfRentalDal());
            var result = rtnmgr.GetRentalDetails();

            Console.WriteLine("|CarName|\t" +
                   "|FirstName|\t" +
                   "|LastName|\t" +
                   "|RentDate|\t" +
                   "|ReturnDate|\t" +
                   "|DailyPrice tl|\t" +
                   "|TotalPrice  tl|\n" +
                   "_____________________________________________________________________________________________________________________");

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarName + "\t\t" +
                    item.FirstName + "\t" +
                    item.LastName + "\t\t" +
                    item.RentDate.ToShortDateString() + " \t" +
                    (item.ReturnDate != default ? item.ReturnDate.ToShortDateString() : null) + "\t" +
                    item.DailyPrice + " tl\t\t" +
                    item.TotalPrice + " tl");
            }
        }

        private static void RentalRetrieve()
        {
            RentalManager rntlmngr = new RentalManager(new EfRentalDal());
            var result = rntlmngr.GetByRentalİd(3);
            Console.WriteLine(rntlmngr.CarRetrieve(result.Data).Message);

            // Console.WriteLine(rntlmngr.Add(new Rental { Id = 3, CarId = 2, CustomerId = 2, RentDate = new DateTime(2021, 01, 26) }).Message);
        }

        private static void AddCustomer()
        {
            CustomerManager cstmrmgnr = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(cstmrmgnr.Add(new Customer { CustomerId = 1, UserId = 5, CompanyName = "Spacex" }).Message);
            Console.WriteLine(cstmrmgnr.Add(new Customer { CustomerId = 2, UserId = 9, CompanyName = "Microsoft" }).Message);
            Console.WriteLine(cstmrmgnr.Add(new Customer { CustomerId = 3, UserId = 99, CompanyName = "Tedaş" }).Message);
        }

        private static void AddUsers()
        {
            UserManager usrmngr = new UserManager(new EfUserDal());
            usrmngr.Add(new User { Id = 1, FirstName = "Ahmet", LastName = "Sağlam", Email = "Ahmtsglm@gmail.com", Password = "ahmt1791" });
            usrmngr.Add(new User { Id = 2, FirstName = "Mehmet", LastName = "Yılmaz", Email = "mhmtylmz@gmail.com", Password = "mhmt1791" });
            usrmngr.Add(new User { Id = 3, FirstName = "Şevket", LastName = "Öztürk", Email = "svktoztrk@gmail.com", Password = "şkvt1791" });
            usrmngr.Add(new User { Id = 4, FirstName = "Cevdet", LastName = "Şengör", Email = "cvdtsgr@gmail.com", Password = "cvdt1791" });
        }

        private static void GetCarDetails()
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            var result = carmanager.GetCarDetails();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarName + " " + item.BrandName + " " + item.ColorName + " " + item.DailyPrice);
            }
        }

        private static void GetAllColorNames()
        {
            ColorManager colormanager = new ColorManager(new EfColorDal());
            foreach (var item in colormanager.GetAll().Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }

        private static void GetAllBrands()
        {
            BrandManager brandmanager = new BrandManager(new EfBrandDal());
            foreach (var item in brandmanager.GetAll().Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void GetById(int id)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarsByBrandId(id).Data)
            {
                Console.WriteLine(item.Description + "  " + item.ModelYear + "   " + item.DailyPrice);
            }
        }
    }
}
