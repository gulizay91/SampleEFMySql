using System;
using System.Linq;
using SampleEFMySql.EFCore;

namespace SampleEFMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetData();
        }

        static void GetData()
        {
            using (var context = new AppDbContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var list = context.Invoice.ToList();
                Console.WriteLine("vkn: " + list.FirstOrDefault().Vkn + " - Price: " + list.FirstOrDefault().TotalPrice.ToString());
            }
        }
    }
}
