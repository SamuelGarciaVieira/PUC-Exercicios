using System;

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
    }
    class Hash
    {

    }
    class Program
    {
        static void Main(string[args])
        {

        }
    }
}