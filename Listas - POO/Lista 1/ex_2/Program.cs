using System;

namespace ex_2
{
    class Program
    {
        static void Panel()
        {
            Console.WriteLine("===== Calculadora v.0 =====");
            Console.WriteLine("1. Soma\n2. Subtração\n3. Multiplicação\n4. Divisão\n5. Finalizar");
            Console.WriteLine("===========================");
            Console.WriteLine("");
        }
        public static void Main(string[] args) { 
            
            Calculadora calculadora = new Calculadora();
            bool x = true;
            double opcao = 0,valor,valorSalvo;

            while (x)
            {
                Panel();
                Console.WriteLine("Insira uma opção");
                opcao = double.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            valorSalvo = calculadora.Valor();
                            Console.Write(valorSalvo + " + ");
                            valor = double.Parse(Console.ReadLine());
                            calculadora.Soma(valor);
                            break;
                        }
                    case 2:
                        {
                            valorSalvo = calculadora.Valor();
                            Console.Write(valorSalvo + " - ");
                            valor = double.Parse(Console.ReadLine());
                            calculadora.Subtracao(valor);
                            break;
                        }
                    case 3:
                        {
                            valorSalvo = calculadora.Valor();
                            Console.Write(valorSalvo + " x ");
                            valor = double.Parse(Console.ReadLine());
                            calculadora.Multiplicar(valor);
                            break;
                        }
                    case 4:
                        {
                            valorSalvo = calculadora.Valor();
                            Console.Write(valorSalvo + " / ");
                            valor = double.Parse(Console.ReadLine());
                            calculadora.Dividir(valor);
                            break;
                        }
                    case 5:
                        {
                            x = false;
                            Console.WriteLine("Fim!");
                            break;
                        }
                }
                Console.Clear();
            }
        }
    }
}
