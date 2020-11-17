using System;

namespace Algoritimo__de_Tabuada_17_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,resultado;

            Console.WriteLine("Digite o número que deseja para apresentar a tabuada");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero*i;
                Console.WriteLine(resultado);
            }

        }//FIM DO MAIN
    }
}
