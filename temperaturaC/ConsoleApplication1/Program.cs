using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Digite a temperatura em Farenheit");
            F = double.Parse(Console.ReadLine());
            C = (F-32)/1.8;
            Console.WriteLine("A Temperatura em Celsius é " + C);
            Console.ReadKey();
        }
    }
}
