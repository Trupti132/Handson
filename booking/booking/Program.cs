using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking
{
    class Program

    {
        public static string myVar; 
         
    static void Main(string[] args)
        {
            List<string> AppointmentSchedule = new List<string>();

            myVar = Console.ReadLine();

            AppointmentSchedule.Add(myVar);
            foreach (var x in AppointmentSchedule)
            {
                DateTime date = DateTime.Parse(x);

                Console.WriteLine(date.ToString("yyyy M d  HH mm ss"));
            }
            Console.Read();

            List<string> Appointmenthaspassed = new List<string>();
            
            myVar= Console.ReadLine();
            Appointmenthaspassed.Add(myVar);

            foreach (var y in Appointmenthaspassed)
            {
                Console.Write(Appointmenthaspassed.Contains(myVar));
                Console.Read();
            }

            List<string> Isafternoonappointment = new List<string>();
            Isafternoonappointment.Add(myVar);
            TimeSpan start = new TimeSpan(12, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);
            if(start<=end)
            {
                Console.WriteLine("Appointment is in afternoon");
                foreach(var i in Isafternoonappointment)
                {
                    Console.WriteLine(Isafternoonappointment.Contains(i));
                    Console.ReadLine();
                }
            }

            List<string> Description = new List<string>();
            
            Description.Add("7/25/2019 13:45:00");
            foreach (var d in Description)
            {
                Console.WriteLine("Appointment on {0}", d);
                Console.ReadLine();
            }

        }
    }
    
}
