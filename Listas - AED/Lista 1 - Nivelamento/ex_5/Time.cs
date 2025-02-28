using System;
using System.IO;
using System.Text;

namespace ex_5
{
    public class Jogador
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string nome = "";

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string posicao = "";

        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        public Jogador(int numero, string nome, string posicao)
        {
            Numero = numero;
            Nome = nome;
            Posicao = posicao;
        }
    }
    public class Time
        {
            //Atributos
            private string Nome { get; set; }
            private Jogador[] titulares;
            private Jogador[] reserva;
            private int quantTitulares;
            private int quantReserva;

            //Construtor
            public Time(string nome)
            {
                Nome = nome;
                titulares = new Jogador[11];
                reserva = new Jogador[12];
                quantTitulares = 0;
                quantReserva = 0;
            }

            //Metodos
            public bool AdicionarTitular(Jogador jogador)
            {
                if (quantTitulares < 11)
                {
                    titulares[quantTitulares] = jogador;
                    quantTitulares++;
                    return true;
                }
                return false;
            }
            public bool AdicionarReserva(Jogador jogador)
            {
                if (quantReserva < 12)
                {
                    reserva[quantReserva] = jogador;
                    quantReserva++;
                    return true;
                }
                return false;
            }
            public bool SubstituirTitular(Jogador jogador, string substituir)
            {
                for(int i = 0; i < quantTitulares; i++)
                {
                    if (titulares[i].Nome == substituir)
                    {
                        titulares[i] = jogador;
                        return true;
                    }
                }
                return false;
            }
            public bool SubstituirReserva(Jogador jogador, string substituir)
            {
                for (int i = 0; i < quantReserva; i++)
                {
                    if (reserva[i].Nome == substituir)
                    {
                        reserva[i] = jogador;
                        return true;
                    }
                }
                return false;
            }
            public bool ConsultarTitular(string jogador)
            {
                for(int i = 0; i < quantTitulares; i++)
                {
                    if (titulares[i].Nome == jogador)
                    {
                        return true;
                    }
                }
                return false;
            }
            public bool ConsultarReserva(string jogador)
            {
                for (int i = 0; i < quantReserva; i++)
                {
                    if (reserva[i].Nome == jogador)
                    {
                        return true;
                    }
                }
                return false;
            }
            public bool ExcluirTitular(string jogador)
            {
                for (int i = 0; i < quantTitulares; i++)
                {
                    if (titulares[i].Nome == jogador)
                    {
                        for (int j = i; j < quantTitulares - 1; j++)
                        {
                            titulares[j] = titulares[j + 1];
                        }   
                        titulares[quantTitulares - 1] = null;
                        quantTitulares--;
                        return true;
                    }
                }
                return false;
            }
            public bool ExcluirReserva(string jogador)
            {
                for (int i = 0; i < quantReserva; i++)
                {
                    if (reserva[i].Nome == jogador)
                    {
                        for (int j = i; j < quantReserva - 1; j++)
                        {
                            reserva[j] = reserva[j + 1];
                        }
                        reserva[quantReserva - 1] = null;
                        quantReserva--;
                        return true;
                    }
                }
                return false;
            }
            public void GerarArq(string path)
            {
                try
                { 
                    StreamWriter arquivo = new StreamWriter(path,false, Encoding.UTF8);
                    using(arquivo) 
                    {
                        arquivo.WriteLine("Titulares:");

                        for (int i = 0; i < quantTitulares; i++)
                        {
                            Jogador titular = titulares[i];
                            arquivo.WriteLine($"Número: {titular.Numero}, Nome: {titular.Nome}, Posição: {titular.Posicao}");
                        }

                        arquivo.WriteLine("\nReservas:");

                        for (int i = 0; i < quantReserva; i++)
                        {
                            Jogador reserva = this.reserva[i];
                            arquivo.WriteLine($"Número: {reserva.Numero}, Nome: {reserva.Nome}, Posição: {reserva.Posicao}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
    }
}
