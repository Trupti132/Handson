using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Class1
    {
        public static int hours = 221;
        public double SuccessRate(int speed)
        {
            if(speed>=1 && speed<=4)
            {
                return 1.0;
            }
            if(speed>=5 && speed<=8)
            {
                return 0.9;
            }
            if(speed<=9)
            {
                return 0.8;
            }
            if(speed==10)
            {
                return 0.77;
            }
            
            return speed;
        }
        public double ProductionRateperh(int speed)
        {
            Console.Write("Production Rate per hour :");
            return hours * speed * SuccessRate(speed);
        }
        public int Workingitemspermin (int speed)
        {
            Console.WriteLine("Working items per min :");
            return (int)ProductionRateperh(speed) / 60;
        }


    }
}
