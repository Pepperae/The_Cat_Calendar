using System.Windows.Forms;
using System.Linq;
using The_Cat_Cafe_API;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace The_Cat_Cafe_Agenda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
            //Application.Run(new EventForm());
            //Application.Run(new ContactForm());
            //Application.Run(new UserControlDays());
            //Application.SetCompatibleTextRenderingDefault(false);


            //List<ICat> cats = new List<ICat>();
            //SeedData(cats);

            List<ICustomer> customers = new List<ICustomer>();
            //SeedData(customers);
        }

        public static void SeedData(List<ICat> cats)
        {
            ICat cat1 = new MotherCats
            {
                Name = "Atari",
                Age = 16,
                Gender = "Female"
            };

            cats.Add(cat1);

            ICat cat2 = new MotherCats
            {
                Name = "Lady",
                Age = 13,
                Gender = "Female"
            };

            cats.Add(cat2);

            ICat cat3 = new MotherCats
            {
                Name = "Miss Meow",
                Age = 9,
                Gender = "Female"
            };

            cats.Add(cat3);

            ICat cat4 = new PlayfulCats
            {
                Name = "Konami",
                Age = 3,
                Gender = "Female"
            };

            cats.Add(cat4);

            ICat cat5 = new PlayfulCats
            {
                Name = "MisterMittens",
                Age = 8,
                Gender = "Male"
            };

            cats.Add(cat5);

            ICat cat6 = new PlayfulCats
            {
                Name = "Miss Prissy Pants",
                Age = 3,
                Gender = "Female"
            };

            cats.Add(cat6);

            ICat cat7 = new SleepyCats
            {
                Name = "SirNapsalot",
                Age = 7,
                Gender = "Male"
            };

            cats.Add(cat7);

            ICat cat8 = new Kittens
            {
                Name = "Buttons",
                Age = 1,
                Gender = "Female"
            };

            cats.Add(cat8);

            ICat cat9 = new Kittens
            {
                Name = "Socks",
                Age = 0,
                Gender = "Male"
            };

        }
    }

    //public static void SeedData(List<ICustomer> customers)
    //{
    //    ICustomer customer1 = new Customers
    //    {
    //        Name = "",
    //        DateOfBirth = ""
    //    };
    //}

    public class MotherCats : WorkingCats
    {

    }

    public class PlayfulCats : WorkingCats
    {
    }

    public class SleepyCats : WorkingCats
    {

    }

    public class Kittens : WorkingCats
    {

    }
}


