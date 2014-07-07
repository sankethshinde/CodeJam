using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine(" Enter two nos: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int Result = a + b;
            Console.WriteLine(" Result of 2 nos is : " + Result);
            Console.ReadLine();
        }
    }
}
