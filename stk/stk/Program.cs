using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stk
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            

            for (int i =0; i <3; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                stack.Push(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < 3; i++)
            {
                Person p = (Person)stack.Pop();
                Console.WriteLine(p.ToString());
            }
            Console.Read();
        }
    }
}






        