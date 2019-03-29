using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//using System.Timers;

namespace ThreadTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TimerCallback timerCallback = new TimerCallback(DoIt);
            Timer timer = new Timer(timerCallback);
            timerCallback.Invoke("123");*/
            // 1 interval = 5000ms, 2 interval = 1000ms
            // after 5 second start the DataWrite method, and every 1 second Writes "MultiThreaddd..."
            Timer timer = new Timer(DataWrite, "MultiThreaddd..." , 5000, 1000);
            Console.ReadLine();
            timer.Dispose(); // This both stops the timer and cleans up
        }

        /*private static void DoIt(object state)
        {
            Console.WriteLine("HII");
        }*/

        /*private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Hi!");
        }*/

        static void DataWrite(object data)
        {
            //This runs on pooled thread
            Console.WriteLine(data); // Writes "MultiThreaddd..."
        }
    }
}
