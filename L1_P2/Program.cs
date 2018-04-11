using System;

namespace L1_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome User

            Console.WriteLine();
            Console.WriteLine("Hello, this program will calculate the time difference between two dates.");           
            Console.WriteLine();          
           
            Console.WriteLine("Format: mm/dd/yyyy, mm-dd-yyyy, m-d-yyyy, or January 9 2017");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();

            // First Date input

            First:
            Console.WriteLine("Date 1: ");            
            Console.WriteLine();
            string date1 = Console.ReadLine();
            DateTime dt1;

            //Input Validation

            if (DateTime.TryParse(date1, out dt1))
            {
                String.Format("{0:d/MM/yyyy}", dt1);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please use this format: mm/dd/yyyy, mm-dd-yyyy, m-d-yyyy, or January 9 2017");
                Console.WriteLine();
                goto First;
            }
                       
            // Second Date input

            Second:
            Console.WriteLine("Date 2: ");
            Console.WriteLine();
            string date2 = Console.ReadLine();
            DateTime dt2;

            // Input Validation

            if (DateTime.TryParse(date2, out dt2))
            {
                String.Format("{0:d/MM/yyyy}", dt2);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please use this format: mm/dd/yyyy, mm-dd-yyyy, m-d-yyyy, or January 9 2017");
                Console.WriteLine();
                goto Second;
            }           
            
            // Difference in dates to TimeSpan

            TimeSpan ts = dt1 - dt2;
                     
            float days = Math.Abs(ts.Days);
            float years = days / 365;
            float months = years * 12;
            float hours = days * 24;
            float minutes = hours * 60;
                        
            Console.WriteLine("Difference In: ");
            Console.WriteLine();
            Console.WriteLine("Years: {0}", years);
            Console.WriteLine();
            Console.WriteLine("Months: {0}", months);
            Console.WriteLine();
            Console.WriteLine("Days: {0} ", days);
            Console.WriteLine();
            Console.WriteLine("Hours: {0} ", hours);
            Console.WriteLine();
            Console.WriteLine("Minutes: {0} ", minutes);
            Console.WriteLine();

            Console.WriteLine("Press any key to try again.");
            Console.ReadKey(true);
            Console.WriteLine();
            goto First;       
                     
        }
           
    }
}

