using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace velocidadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Escolha a opção que você costuma dirigir: ");
            
            Console.WriteLine("Opção1 = 75 km/h");
            Console.WriteLine("Opção2 = 65 km/h");
            Console.WriteLine("Opção3 = 55 km/h ");
            Console.WriteLine("Opção4 = 45 km/h");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    x = 75;
                    Console.WriteLine("Você está acima da velocidade máxima permitida");
                    break;
                case 2:
                    x = 65;
                    Console.WriteLine("Você está acima da velocidade máxima permitida");
                    break;
                case 3:
                    Console.WriteLine("Você está na velocidade máxima permitida");

                    x = 55;
                    break;
                case 4:
                    Console.WriteLine("Você está abaixo da velocidade máxima permitida");
                    x = 45;
                    break;
                                }
            Console.ReadKey();
        }
    }
}