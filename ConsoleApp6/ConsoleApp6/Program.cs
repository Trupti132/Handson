using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            string authors = "Mahesh Chand, Henry He, Chris Love, Raj Beniwal, Praveen Kumar";
            // Split authors separated by a comma followed by space  
            string[] authorsList = authors.Split(',');
            foreach (string author in authorsList)
                Console.WriteLine(author);


            Console.Read();
        }
    }
}
