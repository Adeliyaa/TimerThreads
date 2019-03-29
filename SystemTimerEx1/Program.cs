using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers; // Timers namespace rather than Threading  ---> cover the timer in Threading 

namespace SystemTimerEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(); // Doesnt require any args
            //Timer timer1 = new Timer();
            timer.Interval = 500;
            timer.Elapsed += timer_Elapsed; // Uses an event instead of a delegate
            //timer1.Interval = 500;
            //timer1.Elapsed += timer_Elapsed;
            timer.Start(); // Start the timer
            //timer1.Start();
            Console.ReadLine(); // by Enter
            timer.Stop(); // Stop the timer
            Console.ReadLine(); 
            timer.Start(); // Restart the timer
            Console.ReadLine();
            timer.Dispose(); // Permanently stop the timer
        }
         
        static void timer_Elapsed(object sender, EventArgs e)
        {
            Console.WriteLine("Tick");
        }
    }
}
