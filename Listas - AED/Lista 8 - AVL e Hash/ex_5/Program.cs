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
        public Celula Remover(int matricula)
        {
            Celula tmp = primeiro;
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Matricula == matricula)
                {
                    tmp.Prox = i.Prox;
                    i.Prox = null;
                    return i;
                }

            }
            return null;
        }

        public bool Pesquisar(int x)
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Matricula == x)
                {
                    Console.WriteLine($"Matrícula: {i.Matricula}");
                    Console.WriteLine($"Nome: {i.Nome}");
                    Console.WriteLine($"Curso: {i.Curso}");
                    Console.WriteLine("");
                    return true;
                }
            }
            return false;
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
        private int FuncaoHash(int x)
        {
            return x % tabela.Length;
        }
        public bool Pesquisar(int x)
        {
            return tabela[FuncaoHash(x)].Pesquisar(x);
        }
        public void Remover(int x)
        {
            if (Pesquisar(x) == false)
            {
                throw new Exception("Erro ao remover!");
            }
            else
            {
                tabela[FuncaoHash(x)].Remover(x);
            }
        }
        public void Inserir(int matricula, string nome, string curso)
        {
            if (Pesquisar(matricula) == true)
            {
                throw new Exception("Erro ao inserir!");
            }
            else
            {
                tabela[FuncaoHash(matricula)].InserirFim(matricula, nome, curso);
                Console.WriteLine("Cadastro inserido.");
            }
        }
    }

    class Program
    {
        static void Panel()
        {
            Console.WriteLine("1- Inserir um estudante");
            Console.WriteLine("2- Remover um estudante. O usuário deve informar a matrícula do estudante a ser removido");
            Console.WriteLine("3- Pesquisar um estudante. Caso conste deve-se imprimir todos os dados do estudante, senão deve-se imprimir a mensagem: Estudante não cadastrado");
            Console.WriteLine("4 - Sair.");
        }
        static void Main(string[] args)
        {
            int op = 0;
            int matricula;
            string nome, curso;
            Hash hash = new Hash(101);
            Celula celula = new Celula();
            while (op != 4)
            {
                Panel();
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Insira a matricula:");
                            matricula = int.Parse(Console.ReadLine());

                            Console.WriteLine("Insira seu nome:");
                            nome = Console.ReadLine();

                            Console.WriteLine("Insira seu curso:");
                            curso = Console.ReadLine();

                            hash.Inserir(matricula,nome,curso);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Insira uma matricula a ser removida:");
                            matricula = int.Parse(Console.ReadLine());
                            try
                            {
                                hash.Remover(matricula);
                                Console.WriteLine("Estudante removido com sucesso!");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Insira uma matricula a ser pesquisada:");
                            matricula = int.Parse(Console.ReadLine());
                            
                            if(!hash.Pesquisar(matricula)){
                                Console.WriteLine("Estudante não cadastrado");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Fim!");
                            break;
                        }
                }
            }
        }
    }
}