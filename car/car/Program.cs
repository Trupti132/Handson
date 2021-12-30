using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine("Success rate :{0}",c.SuccessRate(10));
            Console.WriteLine(c.SuccessRate(10));
            Console.WriteLine(c.ProductionRateperh(10));
            Console.WriteLine(c.Workingitemspermin(10));
            Console.ReadLine();
        }
    }
}
