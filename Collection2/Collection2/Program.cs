using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection2
{
    class Program
    {
        static void Main(string[] args)
        {
            //***********Q1*****//
            //List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            //foreach (var i in mylist)
            //{
            //    Console.Write(i.ToString() + " ");
            //}
            //Console.ReadKey();
            //***********Q1*****//

            //***********Q2*****//
            //List<string> mylist = test(new List<string>(new string[] { "1", "2", "3", "4" }));
            //foreach (var i in mylist)
            //{
            //    Console.Write(i.ToString() + " ");
            //}
            //Console.ReadLine();
            //***********Q2*****//


            //***********Q3*****//
            List<string> mylist = test(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadLine();
            //***********Q3*****//

        }

        //***********Q1*****//
        //public static List<int> test(List<int> nums)
        //{
        //    IEnumerable<int> e = nums.Select(x => 5 * (x + 2));
        //    return e.ToList();
        //}
        //***********Q1*****//

        //***********Q2*****//
        //public static List<string> test(List<string> nums_str)
        //{
        //    IEnumerable<string> s = nums_str.Select(x => x = x + x + x + x);
        //    return s.ToList();
        //}
        //***********Q2*****//

        //***********Q3*****//

        public static List<string> test(List<string> str)
        {
            return str.Select(x => x.Replace("a", "")).ToList();
        }

        //***********Q3*****//

    }

}
