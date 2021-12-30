using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
  
            class Program
        {
            static void Main(string[] args)
            {
                Laptop lp = new Laptop();

                lp.ShowDetails(Laptop.Lenove, Laptop.Price1000, Laptop.i3, Laptop.Ram2GB, Laptop.HD500GB);
                Console.WriteLine("\n");



                Console.ReadKey();
            }
        }
        class Laptop : LaptopBase
        {
            public void ShowDetails(string name, string price, string processor, string ram, string hdd)
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Price : " + price);
                Console.WriteLine("Processor : " + processor);
                Console.WriteLine("Ram : " + ram);
                Console.WriteLine("HDD : " + hdd);
            }
        }

        class LaptopBase
        {
            public const string Lenove = "Lenovo";


            public const string Price1000 = "$1000";


            public const string i3 = "i3";


            public const string Ram2GB = "2GB";


            public const string HD500GB = "500GB";

        }
    
}
    
