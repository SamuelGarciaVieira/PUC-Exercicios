using System;

namespace ex_3
{
    class Program
    {
        /*
           Leia dois vetores de inteiros x e y, cada um com N elementos. Considere que o usuário não informará elementos
           repetidos. O valor de N deve ser lido do teclado. Calcule e mostre o resultado das seguintes operações:
           • Soma entre x e y: soma de cada elemento de x com o elemento da mesma posição em y.
           • Produto entre x e y: multiplicação de cada elemento de x com o elemento da mesma posição em y.
           • Diferença entre x e y: todos os elementos de x que não existam em y.
           • Interseção entre x e y: apenas os elementos que aparecem nos dois vetores.
           • União entre x e y: todos os elementos de x, e todos os elementos de y que não estão em x. 
          */
        static void Main(string[] args)
        {
            // Definir tamanho dos vetores
            Console.Write("Informe o tamanho dos arrays: ");
            int size = int.Parse(Console.ReadLine());

            // Vetores iniciais
            int[] vetX = new int[size];
            int[] vetY = new int[size];

            // Vetores solicitados
            int[] vetSoma = new int[size];
            int[] vetProduto = new int[size];
            int[] vetDiferenca = new int[size];
            int[] vetIntersecao = new int[size];

            // Vetor União
            int[] vetUniao = new int[size * 2];
            int contUniao = 0;

            // Inserção de valores nos vetores
            for (int i = 0; i < size; i++)
            {
                Console.Write("Insira um valor no array X: ");
                vetX[i] = int.Parse(Console.ReadLine());

                Console.Write("Insira um valor no array Y: ");
                vetY[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            // Processamento das operações
            for (int i = 0; i < size; i++)
            {
                vetSoma[i] = vetX[i] + vetY[i];
                vetProduto[i] = vetX[i] * vetY[i];
                vetDiferenca[i] = vetX[i] - vetY[i];

                // Interseção
                if (vetX[i] == vetY[i])
                {
                    vetIntersecao[i] = vetX[i];
                }

                // União
                bool contX = false;
                bool contY = false;

                for (int j = 0; j < contUniao; j++)
                {
                    if (vetUniao[j] == vetX[i])
                    {
                        contX = true;
                    }
                    if (vetUniao[j] == vetY[i])
                    {
                        contY = true;
                    }
                }

                if (!contX)
                {
                    vetUniao[contUniao++] = vetX[i];
                }
                if (!contY)
                {
                    vetUniao[contUniao++] = vetY[i];
                }
            }

            // Impressão de valores
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Soma: {vetSoma[i]}");
                Console.WriteLine($"Produto: {vetProduto[i]}");
                Console.WriteLine($"Diferença: {vetDiferenca[i]}");

                if (vetX[i] == vetY[i])
                {
                    Console.WriteLine($"Interseção: {vetIntersecao[i]}");
                }
                Console.WriteLine();
            }

            // Impressão do array União
            Console.WriteLine("União:");
            for (int i = 0; i < contUniao; i++)
            {
                Console.WriteLine(vetUniao[i]);
            }

            Console.ReadKey();

        }
    }
}