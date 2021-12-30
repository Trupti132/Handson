using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            {
                Student s = new Student(1, "John", "F#");
                //calling methods:
                int feePaid = s.Payment(900);
                //checking is th course was paid in total
                s.DueAmount();
                //printing:
                Console.WriteLine(s.Print());
               
                Console.ReadLine();
            }
        }

    }
    
}

     
    

