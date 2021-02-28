using System; //Palavra reservada que adiciona as bibliotecas necessárias para que o programa funcione
using System.Runtime.Serialization;

namespace CalculadoraDeSignos //utilizado para organizar seus códigos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite seu dia de nascimento: \n(ex: 01)");
                Console.Write("R: ");
                int dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu mês de nascimento: \n(ex: 12)");
                Console.Write("R: ");
                int mes = int.Parse(Console.ReadLine());

                InterpretadorSigno intS = new InterpretadorSigno();
                Signo signo = intS.Interpretar(dia, mes);
                if (signo != null)
                {
                    if (dia > 0 && mes > 0 && dia <= 31 && mes <= 12)
                    {
                        Console.WriteLine(signo.ToString());
                    } else
                    {
                        throw new Exception("Informações inseridas são inválidas!");
                    }

                } else
                {
                    throw new Exception("Não foi possível encontrar os dados solicitados!");
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu o seguinte erro: {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}
