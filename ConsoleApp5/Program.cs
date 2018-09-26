using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            string holder;

            bool makeMore;

            double p1Hours;
            double p1Pay;
            double p1Total;
            double p2Hours;
            double p2Pay;
            double p2Total;

            Console.WriteLine("Person1 - Hourly Pay:");
            holder = Console.ReadLine();
            p1Pay = Convert.ToDouble(holder);
            Console.WriteLine("Person1 - Hours Worked");
            holder = Console.ReadLine();
            p1Hours = Convert.ToDouble(holder);
            p1Total = (p1Hours * p1Pay);

            Console.WriteLine("Person2 - Hourly Pay:");
            holder = Console.ReadLine();
            p2Pay = Convert.ToDouble(holder);
            Console.WriteLine("Person2 - Hours Worked:");
            holder = Console.ReadLine();
            p2Hours = Convert.ToDouble(holder);
            p2Total = (p2Hours * p2Pay);
            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine(p1Total);
            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine(p2Total);

            makeMore = p1Total > p2Total;

            Console.WriteLine("Dpoes Person1 make more than Person2?");
            Console.WriteLine(makeMore);

            Console.ReadLine();
        }
    }
}
