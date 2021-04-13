using System;

namespace Decisoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            if(n1 < 0){ 

                Console.Write("Voce digitou um número negativo!");


            }
        }
    }
}
