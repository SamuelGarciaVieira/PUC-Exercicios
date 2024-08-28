using System;

namespace ex_4
{
    class Program
    {
        /*
         Faça um programa que apure o resultado de uma votação para determinar o representante da turma do 1º
         período do curso de Sistemas de Informação. O programa deverá solicitar que seja informada a quantidade de
         candidatos a representante. Em seguida, o programa deverá ler os nomes dos candidatos. O primeiro candidato
         informado terá o número 0, o segundo candidato informado terá o número 1, o terceiro candidato informado
         terá o número 2, e assim por diante. O programa deverá ler os votos de 60 alunos, isto é, o número do candidato
         que cada um dos 60 alunos deseja votar. O programa deverá calcular e apresentar como resultado:
         • o nome e a quantidade de votos do candidato mais votado
         • o número e a quantidade de votos do candidato menos votado
         • a quantidade de votos nulos (isto é, número inválido).
         */
        static void Main(string[] args)
        {
            //Inserção inicial dos representantes e variaveis
            Console.Write("Insira o numero de representantes: ");
            int num = int.Parse(Console.ReadLine());
            string[] nomes = new string[num];
            int[] votacao = new int[num];
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int primeiro = -1;
            int ultimo = -1;
            int nulo = 0;


            //Preencher vetor representantes
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Nome do representante {i}: ");
                string nome = Console.ReadLine();
                nomes[i] = nome;
            }

            //Processamento votos
            for(int i = 0; i < 60; i++)
            {
                Console.Write($"Voto do aluno {i + 1}: ");
                int voto = int.Parse(Console.ReadLine());
                if (voto >= 0 && voto < num)
                {
                    votacao[voto]++;
                }
                else
                {
                    nulo++;
                }
            }

            //Conferir votos
            for (int i = 0; i < votacao.Length; i++)
            {
                if (votacao[i] > maior)
                {
                    maior = votacao[i];
                    primeiro = i;
                }

                if (votacao[i] < menor)
                {
                    menor = votacao[i];
                    ultimo = i;
                }
            }
            //Output
            Console.WriteLine($"O candidato mais votado foi: {primeiro} com {maior}");
            Console.WriteLine($"O candidato menos votado foi: {ultimo} com {menor}");
            Console.WriteLine($"Quantidade de votos nulos: {nulo}");

        }
    }
}