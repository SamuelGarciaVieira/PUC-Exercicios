using System;

namespace ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento do objeto
            Biblioteca biblioteca = new Biblioteca();

            //Adicionar livros
            biblioteca.AdicionarLivro(new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", "HarperCollins"));
            biblioteca.AdicionarLivro(new Livro("1984", "George Orwell", "Companhia das Letras"));
            biblioteca.AdicionarLivro(new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Agir"));
            biblioteca.AdicionarLivro(new Livro("Dom Quixote", "Miguel de Cervantes", "Penguin Books"));

            //Buscar dados do livro
            string busca = "1984";
            Livro livro = biblioteca.Procurar(busca);

            if (livro != null)
            {
                Console.WriteLine($"Livro encontrado: \nTítulo: {livro.Titulo}\nAutor(es): {livro.Autores}\nEditora: {livro.Editora}\n");
            }
            else
            {
                Console.WriteLine($"Livro com o título '{busca}' não encontrado.\n");
            }

            //Relação de livros
            int numero = biblioteca.NumeroAcervo();
            Console.WriteLine("Livros no acervo: " + numero);
            Console.WriteLine("Nome dos livros no acervo:");
            string lista = biblioteca.AcervoCompleto();
            Console.WriteLine(lista);

        }
    }
}