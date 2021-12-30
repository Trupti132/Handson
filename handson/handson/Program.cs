using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "ABC", "asp.net");
            s.Payment(1000);
            s.Print();
            Console.WriteLine(s.DueAmount);


            Console.ReadLine();
        }
    }
}
