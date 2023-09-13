using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYS_OF_THE_WEEK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter DAY OF THE WEEKS");
            int Day = Convert.ToInt32(Console.ReadLine());
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;


            }

            if (Day >= 1 && Day <= 5)
            {
                Console.WriteLine("Happy weekdays");
            }
            else if (Day >= 6 && Day <= 7)
            {
                Console.WriteLine("Happy weekend");
            }
            else if (Day > 7)
            {
                Console.WriteLine("Not a day of the week");
            }
            Console.ReadLine();
        }
    }
}
