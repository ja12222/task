using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome in eslams lundry");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("small carbet=25$");
            Console.WriteLine("");
            Console.WriteLine("large carbet=35$");
            Console.WriteLine("");
            Console.WriteLine("!Sales tax rate is 6%\r\n    Estimates are valid for 30 days!\r\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("how meany small carbet");
            int small =Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("how meany large carbet");
            int big = Convert.ToInt16(Console.ReadLine());
            int price =25*small+35*big;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"the price is:{price}$");
            
       





        }
    }
}
