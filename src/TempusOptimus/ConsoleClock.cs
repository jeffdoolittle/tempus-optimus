using System;
using System.Threading;

namespace TempusOptimus
{
    public class ConsoleClock
    {
        public void Run()
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Console.Clear();
            Console.Write("[Tempus Optimus]");
            var today = OptimaDate.Today;
            WriteToConsole(today);
            var now = OptimaTime.Now;
            WriteToConsole(now);
            while (true)
            {
                OptimaDate optimaDate = OptimaDate.Today;
                if (optimaDate.DayOfYear > today.DayOfYear)
                {
                    today = optimaDate;
                    Console.Beep();
                }
                WriteToConsole(optimaDate);
                OptimaTime optimaTime = OptimaTime.Now;
                if (optimaTime.Modes > now.Modes)
                {
                    now = optimaTime;
                    Console.Beep();
                }
                WriteToConsole(optimaTime);
                Thread.Sleep(86);
            }
        }

        private static void WriteToConsole(OptimaDate date)
        {
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Today is {0} ({1})", date.ToLongDateString(), date.ToShortDateString());
        }

        private static void WriteToConsole(OptimaTime time)
        {
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("The time is {0}", time.ToString(2));
        }
    }
}