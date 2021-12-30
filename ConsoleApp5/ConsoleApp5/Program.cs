using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("No of scores: ");
            int numScores = int.Parse(Console.ReadLine());
            int[] testScores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                Console.Write("{0} Test Score : ", (i + 1));
                testScores[i] = int.Parse(Console.ReadLine());
            }


            Student s = new Student(firstName, lastName, id, testScores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate());




            Console.ReadLine();
        }
    }
}