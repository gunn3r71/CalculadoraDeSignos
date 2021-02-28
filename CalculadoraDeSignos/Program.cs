using System; //Palavra reservada que adiciona as bibliotecas necessárias para que o programa funcione

namespace CalculadoraDeSignos //utilizado para organizar seus códigos
{
    class Program
    {
        static void Main(string[] args)
        {
            Signo signo = new Signo();
            signo.Nome = "Leão";
            signo.DiaInicio = 22;
            signo.MesInicio = 07;
            signo.DiaFim = 22;
            signo.MesFim = 08;
            signo.Descricao = "Carismáticas e terem personalidades fortes";


            Console.WriteLine(signo.ToString());

        }
    }
}
