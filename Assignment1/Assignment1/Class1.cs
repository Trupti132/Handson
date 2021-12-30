using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Class1
    {
        public void Network()
        {
            FileStream fileStreamObj = new FileStream(@"C:\cg\networklog.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fileStreamObj);

            Console.WriteLine("Id  \tSource  \t Destination  \t  Date \t\t Status Network");

            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(':');
                if (line != "")
                {
                    if (values.Length > 1)
                    {
                        if(line.StartsWith("Date"))
                        {
                            string date = values[1].Split(' ')[0];
                            Console.Write(date +"\t");
                        }
                        else
                       
                            Console.Write(values[1]+"\t");
                    }
                }


                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
