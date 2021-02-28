using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace CalculadoraDeSignos
{
    class InterpretadorSigno
    {
        private Signo[] signos = new Signo[12];

        public InterpretadorSigno()
        {
            signos[0] = new Signo { DiaInicio = 21, MesInicio = 03, DiaFim = 20, MesFim = 04, Nome = "Áries", Descricao = "Mostrar o valor da iniciativa, dar o primeiro passo e estimular as pessoas" };
            signos[1] = new Signo { DiaInicio = 21, MesInicio = 04, DiaFim = 20, MesFim = 05, Nome = "Touro", Descricao = "Concluir o que começar e provar que é preciso construir sonhos com os pés na realidade" };
            signos[2] = new Signo { DiaInicio = 21, MesInicio = 05, DiaFim = 20, MesFim = 06, Nome = "Gêmeos", Descricao = "Perguntar, compreender e comunicar aos outros tudo o que aprender" };
            signos[3] = new Signo { DiaInicio = 21, MesInicio = 06, DiaFim = 21, MesFim = 07, Nome = "Câncer", Descricao = "Valorizar a emoção e mostrar que também é preciso enxergar com o coração" };
            signos[4] = new Signo { DiaInicio = 22, MesInicio = 07, DiaFim = 22, MesFim = 08, Nome = "Leão", Descricao = "Destacar a beleza, a alegria e a grandiosidade do que há de bom no mundo" };
            signos[5] = new Signo { DiaInicio = 23, MesInicio = 08, DiaFim = 20, MesFim = 09, Nome = "Virgem", Descricao = "Analisar, apontar erros e lembrar a importância do aperfeiçoamento constante" };
            signos[6] = new Signo { DiaInicio = 23, MesInicio = 09, DiaFim = 20, MesFim = 10, Nome = "Libra", Descricao = "Cooperar, mostrar que é preciso ponderar e atenuar desavenças em nome do amor" };
            signos[7] = new Signo { DiaInicio = 23, MesInicio = 10, DiaFim = 20, MesFim = 11, Nome = "Escorpião", Descricao = "Controlar os instintos, desenvolver a intuição e usá-la para praticar o bem" };
            signos[8] = new Signo { DiaInicio = 22, MesInicio = 11, DiaFim = 20, MesFim = 12, Nome = "Sagitário", Descricao = "Mostrar a importância do bom humor, da generosidade e levar a mensagem da esperança" };
            signos[9] = new Signo { DiaInicio = 22, MesInicio = 12, DiaFim = 20, MesFim = 01, Nome = "Capricórnio", Descricao = "Ensinar que é preciso ter responsabilidade e dedicação para progredir" };
            signos[10] = new Signo { DiaInicio = 21, MesInicio = 01, DiaFim = 20, MesFim = 02, Nome = "Aquário", Descricao = "Acreditar no futuro, buscar horizontes novos e lembrar o valor de ser livre" };
            signos[11] = new Signo { DiaInicio = 20, MesInicio = 02, DiaFim = 20, MesFim = 03, Nome = "Peixes", Descricao = "Compreender os mistérios humanos, ter compaixão e confortar quem necessita de apoio" };
        }

        public Signo Interpretar(int dia, int mes)
        {
            Signo signo = null;
            for(int i = 0; i < signos.Length; i++)
            {
                if ((dia >=signos[i].DiaInicio) && (mes == signos[i].MesInicio) || (dia <= signos[i].DiaFim ) && (mes == signos[i].MesFim))
                {
                    signo = signos[i];
                }
            }
            return signo;
        }
    }
}
