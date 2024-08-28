using System;


namespace ex_7
{
    public class Estacionamento
    {
		//Propiedades
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		private int numVagasLivre;

		private string[] vagas;

		public string[] Vagas
		{
			get { return vagas; }
			set { vagas = value; }
		}

		//Construtor
		public Estacionamento(string nome,int numTotalVagas)
		{
			Nome = nome;
			numVagasLivre = numTotalVagas;
			Vagas = new string[numTotalVagas];
		}

		//Propiedade do NumVagas
        public int NumVagasLivre
        {
            get { return numVagasLivre; }
        }
        public int Estacionar(string placa)
		{
			for(int i = 0; i < vagas.Length; i++)
			{
				if (vagas[i] == null)
				{
					vagas[i] = placa;
					return i;
				}
			}
			return -1;
		}
		public int BuscarNumVaga(string placa)
		{
			for(int i = 0; i < vagas.Length; i++)
			{
				if (vagas[i] == placa)
				{
					return i;
				}
			}
			return -1;
		}
		public void Retirar(string placa)
		{
			for(int i = 0; i < vagas.Length; i++)
			{
				if (vagas[i] == placa)
				{
					vagas[i] = null;
				}
			}
		}
        public void ExibirOcupacao()
		{
			for(int i = 0; i < vagas.Length; i++)
			{
				if (vagas[i] != null)
				{
                    Console.WriteLine("Numero da vaga: " + i);
                    Console.WriteLine("Numero da placa: " + vagas[i]);
                }
			}
		}
    }
}
