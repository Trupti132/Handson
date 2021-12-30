using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace handson
{
    class Course
    {
        protected string name;
        protected int duration;
        protected int fee;


        public Course(string name, int duration, int fee)
        {
            this.name = name;
            this.duration = duration;
            this.fee = fee;
        }


        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Duration: " + duration.ToString());
            Console.WriteLine("Fee: " + fee.ToString());
            Console.WriteLine("Total fee: " + GetTotalFee().ToString());
        }


        public virtual double GetTotalFee()
        {
            return fee * duration;
        }

        
    }
    class PartTimeCourse : Course
    {
        protected int discount;
        public PartTimeCourse(string name, int duration, int fee) : base(name, duration, fee)
        {
            discount = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total - (total * discount / 100);
        }
    }


    class OnsiteCourse : Course
    {
        protected double charge;
        public OnsiteCourse(string name, int duration, int fee) : base(name, duration, fee)
        {
            charge = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total + (total * charge / 100);
        }
    }



}