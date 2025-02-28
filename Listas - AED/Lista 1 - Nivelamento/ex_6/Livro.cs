using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ex_6
{
    internal class Livro
    {
        private string titulo;
        private string autores;
        private string editora;

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public Livro(string titulo, string autores, string editora)
        {
            Titulo = titulo;
            Autores = autores;
            Editora = editora;
        }
    }
    internal class Biblioteca
    {
        private Livro[] acervo;
        private int numLivros;
        private const int MAXLIV = 50;

        public Biblioteca()
        {
            acervo = new Livro[MAXLIV];
            numLivros = 0;
        }

        public void AdicionarLivro(string titulo, string autores, string editora)
        {
            if (numLivros < MAXLIV)
            {
                acervo[numLivros].Titulo = titulo;
                acervo[numLivros].Autores = autores;
                acervo[numLivros].Editora = editora;
                numLivros++;
            }
        }
        public void AdicionarLivro(Livro livro)
        {
            if (numLivros < MAXLIV)
            {
                acervo[numLivros] = livro;
                numLivros++;
            }
        }
        public Livro Procurar(string titulo)
        {
            for (int i = 0; i < numLivros; i++)
            {
                if (acervo[i].Titulo == titulo)
                {
                    return acervo[i];
                }
            }
            return null;
        }
        public void ListaNomes()
        {
            for (int i = 0; i < numLivros; i++)
            {
                Console.WriteLine(acervo[i].Titulo);
            }
        }
        public string AcervoCompleto()
        {
            string lista = "";
            for(int i = 0; i < numLivros; i++)
            {
                lista += $"Título: {acervo[i].Titulo}\n";
            }
            return lista;
        }
        public int NumeroAcervo()
        {
            return numLivros;
        }
    }
}
