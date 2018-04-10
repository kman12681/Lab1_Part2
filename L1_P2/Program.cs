using System;

namespace L1_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date");
            DateTime dt1 = DateTime.Parse(Console.ReadLine());
          
            Console.WriteLine("Please enter another date, earlier than the first");
            DateTime dt2 = DateTime.Parse(Console.ReadLine());
          
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
}