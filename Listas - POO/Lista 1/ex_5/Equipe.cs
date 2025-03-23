using System.Collections.Generic;
using System.Text;

namespace ex_5
{
    class Equipe
    {
        #region Variaveis
        /// <summary>
        /// Variavel responsável por receber quantos pontos necessários.
        /// </summary>
        private List<int> _ponto;

        /// <summary>
        /// Variavel responsável por somar pontos.
        /// </summary>
        private int _soma;

        /// <summary>
        /// Formatar pontuação.
        /// </summary>
        private StringBuilder _sb;
        #endregion

        #region Metodos
        /// <summary>
        /// Construtor padrão vazio.
        /// </summary>
        public Equipe()
        {
            _ponto = new List<int>();
            _soma = 0;
            _sb = new StringBuilder();
        }

        /// <summary>
        /// Metodo responsável a adicionar pontos a equipe
        /// </summary>
        /// <param name="ponto"></param>
        /// <returns></returns>
        public void AdicionarPonto(int ponto)
        {
            _ponto.Add(ponto);
        }

        /// <summary>
        /// Metodo responsável por disponibilizar resultado final da partida.
        /// </summary>
        /// <param name="ponto"></param>
        /// <returns></returns>
        public void SomarPontos()
        {
            foreach (int i in _ponto) {
                _soma += i;
            }
        }

        /// <summary>
        /// Metodo para decidir vencedor.
        /// </summary>
        /// <param name="equipe"></param>
        /// <returns></returns>
        public bool PontoEhMaior(Equipe equipe)
        {
            return _soma > equipe._soma;
        }

        /// <summary>
        /// Retorna pontuação formatada.
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            foreach (int i in _ponto) { 
            _sb.Append(i + " ");
            }
            return _sb.ToString();
        }
        #endregion
    }
}