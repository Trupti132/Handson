using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace doc
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsobj = new FileStream("C:\\cg\\details.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fsobj);

           
            Console.WriteLine("Please fill the details below..\n");
            Console.Write("Name: Dr.");
            string name = Console.ReadLine();
            

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Experience: ");
            string expr = Console.ReadLine();

            Console.Write("Address: ");
            string add = Console.ReadLine();

            Console.Write("Contact Number: ");
            int contact = Convert.ToInt32(Console.ReadLine());


            sw.WriteLine(" name:" + name);
            sw.WriteLine("category:" + category);
            sw.WriteLine("experience:" + expr);
            sw.WriteLine("address:" + add);
            sw.WriteLine("Contact:" + contact);

            sw.Close();
            fsobj.Close();
        }
    }
}
