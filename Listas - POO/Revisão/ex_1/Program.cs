using System;
using System.Text;
using static Program;

class Program
{
    public class Hora
    {
        private int _hora;
        private int _minuto;
        private int _segundo;

        /// <summary>
        /// Construtor sem parametros.
        /// </summary>
        public Hora()
        {
            _hora = 0;
            _minuto = 0;
            _segundo = 0;
        }

        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="hora"></param>
        /// <param name="minuto"></param>
        /// <param name="segundo"></param>
        public Hora(int hora, int minuto, int segundo)
        {
            if (Validar(hora, minuto, segundo))
            {
                _hora = hora;
                _minuto = minuto;
                _segundo = segundo;
            }
            else
            {
                _hora = 0;
                _minuto = 0;
                _segundo = 0;
            }
        }

        /// <summary>
        /// Valida as horas do objeto.
        /// </summary>
        /// <param name="hora"></param>
        /// <param name="minuto"></param>
        /// <param name="segundo"></param>
        /// <returns></returns>
        private bool Validar(int hora, int minuto, int segundo)
        {
            return (hora < 24) && (minuto < 60) && (segundo < 60);
        }

        /// <summary>
        /// Adiciona valores nas Horas, atualiza os valores idependente do tamanho.
        /// </summary>
        /// <param name="hora"></param>
        /// <param name="minuto"></param>
        /// <param name="segundo"></param>
        /// <returns></returns>
        public Hora Ajustar(int hora, int minuto, int segundo)
        {
            //Calculo
            int segundoAtualizado = _segundo + segundo;
            int minutoAtualizado = _minuto + minuto + (segundoAtualizado / 60);
            int horaAtualizada = _hora + hora + (minutoAtualizado / 60);

            //Contabilizar excedente
            segundoAtualizado %= 60;
            minutoAtualizado %= 60;
            horaAtualizada %= 60;

            return new Hora(horaAtualizada, minutoAtualizado, segundoAtualizado);
        }

        /// <summary>
        /// Realiza comparação booleana que informa maior horario.
        /// </summary>
        /// <param name="hora"></param>
        /// <returns></returns>
        public bool EstahNaFrenteDe(Hora hora)
        {
            int primeiraHora = _hora * 3600 + _minuto * 60 + _segundo;
            int segundoHora = hora._hora * 3600 + hora._minuto * 60 + hora._segundo;
            return primeiraHora > segundoHora;
        }

        /// <summary>
        /// Retorno formalizado referente a hora.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{_hora}:{_minuto}:{_segundo}";
        }
    }
    public class Duracao
    {
        #region Variaveis
        /// <summary>
        /// Variavel responsável pela hora inicial.
        /// </summary>
        private Hora _horaInicial;

        /// <summary>
        /// Variavel responsável pela duração total de um Evento.
        /// </summary>
        private int _duracaoTotal;
        #endregion

        #region Metodos
        /// <summary>
        /// Construtor padrão.
        /// </summary>
        /// <param name="horaInicial"></param>
        /// <param name="tempoEmSegundos"></param>
        public Duracao(Hora horaInicial, int tempoEmSegundos)
        {
            _horaInicial = horaInicial;
            _duracaoTotal = tempoEmSegundos;
        }

        /// <summary>
        /// Realiza uma comparação com o atributo da classe.
        /// </summary>
        /// <param name="outraDuracao"></param>
        /// <returns></returns>
        public bool MaiorQue(Duracao outraDuracao)
        {
            return _duracaoTotal > outraDuracao._duracaoTotal;
        }

        /// <summary>
        /// Converte <param name="_duracaoTotal"></param> para segundos
        /// </summary>
        /// <returns></returns>
        public int DuracaoEmSegundos()
        {
            return _duracaoTotal;
        }

        /// <summary>
        /// Retorna um relatorio de uma linha que apresenta três componentes formatados.
        /// </summary>
        /// <returns></returns>
        public string Relatorio()
        {
            //Clona a hora inicial
            Hora horaFinal = _horaInicial;
            //Adiciona o restante a hora
            horaFinal.Ajustar(0, 0, DuracaoEmSegundos());

            return $"Hora inicial: {_horaInicial}, Hora final: {horaFinal}, Duração: {DuracaoEmSegundos()}";
        }
        #endregion
    }
}