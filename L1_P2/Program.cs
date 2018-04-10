using System;

namespace L1_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome User

            Console.WriteLine("Hello, this program will calculate the difference in years, months, days, and minutes between two dates.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("You will enter two dates, please enter the later date first.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("Format: mm/dd/yyyy, or mm-dd-yyyy, or m-d-yyyy, or January 9 2017");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            // First Date input

            Console.WriteLine("Date 1: ");
            DateTime dt1 = DateTime.Parse(Console.ReadLine());

            // Second Date input

            Second:
            Console.WriteLine("Date 2 (earlier than the first): ");
            DateTime dt2 = DateTime.Parse(Console.ReadLine());

            // Validation of Date 2 

            if (dt2 > dt1)
            {
                Console.WriteLine("That date is not earlier.");
                goto Second;
            }

            TimeSpan ts = dt1 - dt2;

            float days = ts.Days;
            float years = days / 365;
            float months = years * 12;
            float hours = days * 24;
            float minutes = hours * 60;
               

            Console.WriteLine("Difference In: ");
            Console.WriteLine("Years: {0}", years);
            Console.WriteLine("Months: {0}", months);
            Console.WriteLine("Days: {0} ", days);
            Console.WriteLine("Hours: {0} ", hours);
            Console.WriteLine("Minutes: {0} ", minutes);

            Console.ReadLine();

        }
           
    }
} // exceptions, when year >9999, days above what that month has
// how can I make it so that any date can be entered first or second, doesn't matter if earlier or later