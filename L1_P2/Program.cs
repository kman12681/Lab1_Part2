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
            
            Console.WriteLine("Date 1: ");
            Console.WriteLine();
            DateTime dt1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            // Second Date input
            
            Console.WriteLine("Date 2: ");
            Console.WriteLine();
            DateTime dt2 = DateTime.Parse(Console.ReadLine());
            

            // Difference in dates to TimeSpan

            TimeSpan ts = dt1 - dt2;
                     
            float days = Math.Abs(ts.Days);
            float years = days / 365;
            float months = years * 12;
            float hours = days * 24;
            float minutes = hours * 60;

            Console.WriteLine();
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

            Console.ReadLine();

        }
           
    }
} 

              // exceptions, when year >9999, days above what that month has
  /*if (dt2 > dt1)
              {
                  Console.WriteLine("That date is not earlier.");

                  Third:
                  Console.WriteLine("Would you like to enter Date 1 again? (y or n, press enter) ");

                  ConsoleKeyInfo cki = Console.ReadKey();

                  if (cki.Key.ToString() == "Y" || cki.Key.ToString() == "y")
                  {
                      Console.ReadKey();
                      goto First;
                  }


                  else if (cki.Key.ToString() == "N" || cki.Key.ToString() == "n")
                  {
                      Console.ReadKey();
                      goto Second; }

                  else
                  {
                      Console.WriteLine("Not a valid entry");
                      goto Third;
                  }

              }*/
