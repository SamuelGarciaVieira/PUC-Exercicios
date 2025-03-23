using System;
using System.Text;

namespace ex_5
{
    public class PartidaBasquete
    {
        #region Variaveis
        /// <summary>
        /// Número de equipes.
        /// </summary>
        Equipe equipe1 = new Equipe();
        Equipe equipe2 = new Equipe();
        
        /// <summary>
        /// Responsável por montar o quadro de pontuação.
        /// </summary>
        StringBuilder sb = new StringBuilder();
        #endregion

        #region Metodos
        /// <summary>
        /// Distribui pontos para as equipes.
        /// </summary>
        /// <param name="ponto"></param>
        public void Rodada()
        { 

            Console.Write($"Digite o ponto da equipe 1: ");
            int ponto = int.Parse(Console.ReadLine());
            equipe1.AdicionarPonto(ponto);
            Console.Write($"Digite o ponto da equipe 2: ");
            int ponto1 = int.Parse(Console.ReadLine());
            equipe2.AdicionarPonto(ponto);
        }

        /// <summary>
        /// Apresenta placar final.
        /// </summary>
        public void PlacarFinal()
        {
            sb.Append($"EQUIPE1: {equipe1.ToString} {equipe1.SomarPontos}");
            sb.Append($"EQUIPE2: {equipe2.ToString} {equipe2.SomarPontos}");
            Console.WriteLine(sb);
        }

        /// <summary>
        /// Realiza funcionamento da partida.
        /// </summary>
        public void Partida()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Rodada " + i);
                Rodada();
                i++;
            } while (i <= 4);
            if (equipe1.PontoEhMaior(equipe2))
            {
                while (equipe1.PontoEhMaior(equipe2))
                {
                    Console.WriteLine("Prorrogação.");
                    Rodada();
                }
            }
            PlacarFinal();
            Console.ReadKey();
        }
        #endregion
    }
}