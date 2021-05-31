using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Digite a temperatura em Grau Celsius");
            C = double.Parse(Console.ReadLine());
            F = C * 1.8 + 32;
            Console.WriteLine("A Temperatura em Farenheit é " + F);
            Console.ReadKey();
        }
    }
}
