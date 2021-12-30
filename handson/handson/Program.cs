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
            //*********Q1************//
            //Student s = new Student(1, "ABC", "asp.net");
            //s.Payment(1000);
            //s.Print();
            //Console.WriteLine(s.DueAmount);


            //Console.ReadLine();

            //**********Q1*************//

            //**********Q2*************//
            var course = new Course("course", 10, 100);
            var partCourse = new PartTimeCourse("partCourse", 10, 100);
            var onsiteCourse = new OnsiteCourse("onsiteCourse", 10, 100);


            course.Print();
            partCourse.Print();
            onsiteCourse.Print();
            Console.ReadLine();
            //**********Q2*************//
        }
    }
}
