using System;

namespace ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento
            Estacionamento estacionamento = new Estacionamento("Estacionamento Puc Minas", 30);

            //Adicionando carros
            estacionamento.Estacionar("1111");
            estacionamento.Estacionar("2222");
            estacionamento.Estacionar("3333");
            estacionamento.Estacionar("4444");
            estacionamento.Estacionar("5555");

            //Primeira exibição
            Console.WriteLine("Exibição 1:");
            estacionamento.ExibirOcupacao();

            //Buscar placa
            string pesquisa = "3333";
            int numPlaca = estacionamento.BuscarNumVaga(pesquisa);
            Console.WriteLine($"A placa {pesquisa} foi encontrada na vaga: {numPlaca}");

            //Retirar carro
            estacionamento.Retirar("5555");

            //Exibir denovo o estacionamento
            Console.WriteLine("Exibição 2:");
            estacionamento.ExibirOcupacao();

            //Adicionando mais 3 carros
            estacionamento.Estacionar("6001");
            estacionamento.Estacionar("1112");
            estacionamento.Estacionar("1231");

            //Ultima exibição
            Console.WriteLine("Exibição 3:");
            estacionamento.ExibirOcupacao();

            //Vagas livres
            Console.WriteLine(estacionamento.NumVagasLivre);
        }
    }
}