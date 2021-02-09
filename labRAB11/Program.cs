using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRAB11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write z");
            int z = Convert.ToInt32(Console.ReadLine());
            double c = (a + b) * (a - 23 * z);
            Console.WriteLine("c={0}", c.ToString());
        }
    }
}
