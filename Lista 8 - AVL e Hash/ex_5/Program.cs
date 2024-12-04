using System;
using ex_5;

namespace ex_5
{
    class Celula
    {
        private int matricula;
        private string nome;
        private string curso;
        private Celula prox;
        public Celula(int matricula, string nome, string curso)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.curso = curso;
            this.prox = null;
        }
        public Celula()
        {
            this.matricula = 0;
            this.nome = "";
            this.curso = "";
            this.prox = null;
        }
        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
    class Lista
    {
        private Celula primeiro, ultimo;
        public Lista()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }
        public bool Pesquisar(int x)
        {
            bool resp = false;
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Matricula == x)
                {
                    resp = true;
                    i = ultimo;
                }
            }
            return resp;
        }
        public void InserirFim(int matricula, string nome, string curso)
        {
            Celula tmp = new Celula(matricula, nome, curso);
            ultimo.Prox = tmp;
            ultimo = tmp;
        }
    }
    class Hash
    {
        public Lista[] tabela;
        public Hash(int m)
        {
            tabela = new Lista[m];
            for (int i = 0; i < m; i++)
            {
                tabela[i] = new Lista();
            }
        }
        private int FuncaoHash(Celula x)
        {
            return x.Matricula % tabela.Length;
        }
        public bool Pesquisar(Celula x)
        {
            return tabela[FuncaoHash(x.Matricula)].Pesquisar(x.Matricula);
        }
        public void Remover(Celula x)
        {
            if (Pesquisar(x.Matricula) == false)
            {
                throw new Exception("Erro ao remover!");
            }
            else
            {
                tabela[FuncaoHash(x.Matricula)].Remover(x);
            }
        }
        public void Inserir(Celula x)
        {
            if (Pesquisar(x.Matricula) == true)
            {
                throw new Exception("Erro ao inserir!");
            }
            else
            {
                tabela[FuncaoHash(x.Matricula)].InserirFim(x);
            }
        }
    }

    class Program
    {
        static void Panel()
        {
            Console.WriteLine("1 - Cadastrar um paciente.");
            Console.WriteLine("2 - Remover um paciente. O usuário deve informar o CPF do paciente a ser removido.");
            Console.WriteLine("3 - Pesquisar um paciente pelo CPF. Caso conste deve-se imprimir todos os dados do paciente, senão deve-se imprimir a mensagem: Paciente não cadastrado.");
            Console.WriteLine("4 - Mostrar o nome de todos os pacientes, usando o caminhamento central.");
            Console.WriteLine("5 - Mostrar os CPS de todos os pacientes, usando o caminhamento pós-ordem.");
            Console.WriteLine("6 - Mostrar os e-mails de todos os pacientes, usando o caminhamento pré-ordem.");
            Console.WriteLine("7 - Sair");
        }
        static void Main(string[] args)
        {
            Panel();
            System.Console.WriteLine();
            int op;
            while (op != 7)
            {
                switch (op)
                {
                    case 1:
                        {

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {

                            break;
                        }
                    case 5:
                        {

                            break;
                        }
                    case 6:
                        {

                            break;
                        }
                    case 7:
                        {

                            break;
                        }
                }
            }
        }
    }
}