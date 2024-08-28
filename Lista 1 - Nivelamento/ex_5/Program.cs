using System;
using System.IO;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento inicial
            Time time = new Time("Time Puc Minas");

            // Adicionar jogadores titulares
            time.AdicionarTitular(new Jogador(1, "Jogador 1", "Atacante"));
            time.AdicionarTitular(new Jogador(2, "Jogador 2", "Meio-campo"));
            time.AdicionarTitular(new Jogador(3, "Jogador 3", "Defensor"));
            time.AdicionarTitular(new Jogador(4, "Jogador 4", "Goleiro"));
            time.AdicionarTitular(new Jogador(5, "Jogador 5", "Atacante"));

            // Adicionar jogadores reservas
            time.AdicionarReserva(new Jogador(6, "Jogador 6", "Meio-campo"));
            time.AdicionarReserva(new Jogador(7, "Jogador 7", "Defensor"));
            time.AdicionarReserva(new Jogador(8, "Jogador 8", "Goleiro"));

            // Substituir um titular
            time.SubstituirTitular(new Jogador(9, "Jogador 9", "Atacante"), "Jogador 1");

            // Substituir um reserva
            time.SubstituirReserva(new Jogador(10, "Jogador 10", "Meio-campo"), "Jogador 6");

            // Consultar se um jogador é titular ou reserva
            bool titular = time.ConsultarTitular("Jogador 9");
            bool reserva = time.ConsultarReserva("Jogador 7");
            Console.WriteLine(titular);
            Console.WriteLine(reserva);

            // Excluir um titular
            bool tirar = time.ExcluirTitular("Jogador 5");
            Console.WriteLine(tirar);

            // Excluir um reserva
            bool tirarReserva = time.ExcluirReserva("Jogador 7");
            Console.WriteLine(tirarReserva);

            // Gerar o arquivo com as informações do time
            string path = "time.txt";
            time.GerarArq(path);
            Console.WriteLine($"Arquivo {path} gerado com sucesso.");
        }
    }
}