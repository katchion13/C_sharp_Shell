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
            int x;
            Console.WriteLine("Digite um número de 1a 3");
            x = int.Parse(Console.ReadLine());
            switch(x){
            case 1:
                Console.WriteLine("O valor de X é UM");
                break;
            case 2:Console.WriteLine("O valor de X é DOIS");
                break;
            case 3:Console.WriteLine("O valor de X é TRÊS");
                break;
            default:
                Console.WriteLine("Qualquer outro valor");
                break;
             }
            Console.ReadKey();
        }
    }
}
