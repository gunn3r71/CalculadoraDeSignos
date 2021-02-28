using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeSignos
{
    class Signo
    {
        private string _nome;
        private int _dia_inicio;
        private int _mes_inicio;
        private int _dia_fim;
        private int _mes_fim;
        private string _descricao;

        public string Nome
        {
            get{ return _nome; }
            set{ _nome = (value != null && value != "") ? value : "Invalid"; }
        }

        public int DiaInicio 
        {
            get { return _dia_inicio; }
            set { _dia_inicio = value; }
        }   

        public int MesInicio
        {
            get { return _mes_inicio; }
            set { _mes_inicio = value; }
        }

        public int DiaFim
        {
            get { return _dia_fim; }
            set { _dia_fim = value; }
        }

        public int MesFim
        {
            get { return _mes_fim; }
            set { _mes_fim = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }



        public override string ToString()
        {
            return $"Seu signo é {Nome}," +
                $"\nO signo de todas as pessoas que nascem de {DiaInicio}/{MesInicio} à {DiaFim}/{MesFim}." +
                $"\nMinha descrição:\n{Descricao}";
        }
    }
}
