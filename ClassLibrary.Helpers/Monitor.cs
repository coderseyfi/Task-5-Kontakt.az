using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helpers
{
  public class Monitor
    {
        public static string ReadString(string caption)
        {
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            return aStr;
        }

        public static DateTime ReadDateTime(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (!DateTime.TryParseExact(aStr, "yyyy.MM.dd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                Monitor.PrintError("yeniden daxil edin");
                goto l1;
            }

            return date;
        }

        public static double ReadDouble(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            double a;

            try
            {
                a = Convert.ToDouble(aStr);
            }
            catch
            {
                Monitor.PrintError("yeniden daxil edin");
                goto l1;
            }

            return a;
        }

        public static int ReadInteger(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            int a;

            try
            {
                a = Convert.ToInt32(aStr);
            }
            catch
            {
                Monitor.PrintError("yeniden daxil edin");
                goto l1;
            }

            return a;
        }

        public static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
