using System;
using System.Timers;            //using this namespace for timer class

namespace UnderstandingTimers
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer mytimer = new Timer(2000);        //for 2 seconds delay
            mytimer.Elapsed += Mytimer_Elapsed;
            mytimer.Elapsed += Mytimer_Elapsed1;


            mytimer.Start();
            Console.WriteLine("press enter to exit red");
            Console.ReadLine();

            mytimer.Elapsed -= Mytimer_Elapsed1;

            Console.ReadLine();
        }

        private static void Mytimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed 1 time :{0:HH:mm:ss.fff}",e.SignalTime);
        }

        private static void Mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed time:{0:HH:mm:ss.fff}",e.SignalTime);    //cmd message 
        }
    }
}
