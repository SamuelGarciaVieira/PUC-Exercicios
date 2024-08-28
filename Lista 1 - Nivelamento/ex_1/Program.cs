using System;

namespace ex_1{
    class Program
    {
        /*
          Faça um programa que leia uma sequência de números inteiros positivos, até que seja informado o valor -1. 
          Este programa deve imprimir qual é o tamanho da maior sequência crescente recebida
            • Exemplo: 12, 4, 8, 15, 16, 23, 42, 9, 11, 7, 5, 77, 95, -1
          Resposta correta: 6 
         */
        public static void Main(string[] args)
        {
            int num = 0;
            int cont = 1;
            int salvacont = 1;
            int num2 = int.MinValue;
            do
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                //Tratamento para evitar bugs de contagem
                if (num == -1)
                {
                    break;
                }

                if (num2 < num)
                {
                    cont++;
                }
                else
                {
                    cont = 1;
                }

                if (cont > salvacont)
                {
                    salvacont = cont;
                }
                num2 = num;

            } while (num != -1);

            Console.WriteLine("Maior sequência: " + salvacont);
        }
    }
}