using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace parallel_prg
{
    class ParallelProgrammingDemo
    {
        public static void ExecuteParallelDemo()
        {
            #region parallel invoke
            Parallel.Invoke(
                () => DoSomeTask(1),
                    () => DoSomeTask(2),
                    () => DoSomeTask(3),
                    () => DoSomeTask(4),
                    () => DoSomeTask(5),
                    () => DoSomeTask(6),
                    () => DoSomeTask(7)
                );
            Console.ReadKey();
            #endregion
        }
    static long DoSomeIndependentTimeconsumingTask()
    {
        //Do Some Time Consuming Task here
        //Most Probably some calculation or DB related activity
        long total = 0;
        for (int i = 1; i < 100000000; i++)
        {
            total += i;
        }
        return total;
    }
    static void DoSomeTask(int number)
    {
        Console.WriteLine($"DoSomeTask {number} started by Thread {Thread.CurrentThread.ManagedThreadId}");
        //Sleep for 5000 milliseconds
        Thread.Sleep(5000);
        Console.WriteLine($"DoSomeTask {number} completed by Thread {Thread.CurrentThread.ManagedThreadId}");
    }
}
}