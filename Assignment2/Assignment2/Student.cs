using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment2
{
    
        class Student
        {

        public int RollNumber { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public int FeePaid { get; set; }
        public int TotalFee { get; private set; }

        public Student(int rollNo, string name, string course)
        {
            this.RollNumber = rollNo;
            this.StudentName = name;
            this.CourseName = course;

            if (CourseName == "C#")
                TotalFee = 2000;
            else if (CourseName == "ASP.NET")
                TotalFee = 3000;
        }

        public int Payment(int amount)
        {
            return FeePaid += amount;
        }

        public string Print()
        {
            return string.Format("Roll number: {0}\r\nName: {1}\r\nCourse: {2}\r\nFee paid: {3}.",
                RollNumber, StudentName, CourseName, FeePaid);
        }

  
        public void DueAmount()
        {
            TotalFee -= FeePaid;
        }
    }
}
    

