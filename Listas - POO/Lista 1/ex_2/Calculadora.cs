namespace ex_2
{
    class Calculadora
    {
        #region Variaveis
        /// <summary>
        /// Variavel que será responsável por receber N valores.
        /// </summary>
        private double _numero;

        #endregion

        #region Metodos
        /// <summary>
        /// Construtor padrão, inicia valores em 0 para contas futuras.
        /// </summary>
        public Calculadora()
        {
            Reset();
        }

        /// <summary>
        /// Função responsável pelo construtor e por reiniciar a calculadora.
        /// </summary>
        public void Reset()
        {
            _numero = 0;
        }

        /// <summary>
        /// Retorna numero para consultar na interface.
        /// </summary>
        /// <returns></returns>
        public double Valor()
        {
            return _numero;
        }

        /// <summary>
        /// Função para somar valor.
        /// </summary>
        /// <param name="valor"></param>
        public void Soma(double valor)
        {
            _numero += valor;
        }

        /// <summary>
        /// Função para diminuir valor.
        /// </summary>
        /// <param name="valor"></param>
        public void Subtracao(double valor)
        {
            _numero -= valor;
        }

        /// <summary>
        /// Função para multiplicar valor.
        /// </summary>
        /// <param name="valor"></param>
        public void Multiplicar(double valor)
        {
            _numero *= valor;
        }

        /// <summary>
        /// Função para dividir valor.
        /// </summary>
        /// <param name="valor"></param>
        public void Dividir(double valor)
        {
            _numero %= valor;  
        }
        #endregion
    }
}