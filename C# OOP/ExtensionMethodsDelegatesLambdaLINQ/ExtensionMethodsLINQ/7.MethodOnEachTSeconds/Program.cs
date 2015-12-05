//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Diagnostics;

namespace _01.ExecuteAtEachSecond
{

    //РЕШЕНИЕТО НЕ Е МОЕ!!! - на zhelyazkovn от форума!!! 
    public delegate void Timer(string message, int seconds); //DECLARE DELEGATE

    public class ExecuteAtEachSecond
    {
        public static void LoopMethod(string message, int seconds) //VOID METHOD WITH THE SAME PARAMETERS LIKE THE DELEGATE
        {
            Stopwatch sw = new Stopwatch(); //DECLARE STOPWATCH
            sw.Start(); //START TIMING
            while (true)
            {
                if (sw.ElapsedMilliseconds == seconds * 1000) //CONVERT SECONDS TO MILISECONDS
                {
                    Console.WriteLine(message);
                    sw.Restart(); //RESTART THE STOPWATCH
                }
            }
        }

        static void Main()
        {
            Timer t = new Timer(LoopMethod); //CREATE NEW TIMER DELEGATE THAT USE LoopMethod
            t("This sentence repeats every five seconds...", 5); // CALL THE METHOD WITH THE APPROPRIATE PARAMETERS
        }
    }
}