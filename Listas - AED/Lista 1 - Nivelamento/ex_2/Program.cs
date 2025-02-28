using System;

namespace ex_2
{
    class Program
    {
        //Faça um programa que leia um número inteiro positivo N e imprima as N primeiras linhas do triangulo de Floyd.
        public static void Main(string[] args)
        {
            Console.Write("Insira o número de termos: ");
            int termo = int.Parse(Console.ReadLine());

            int num = 1;
            for (int i = 1; i <= termo; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                //Espaço final das linhas
                Console.WriteLine();
            }
        }
    }
}