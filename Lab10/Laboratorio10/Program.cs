using System;

namespace Laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa o termometro e mostra seu valor
            TermometroLimite term = new TermometroLimite(5);
            Console.WriteLine(term.ToString());

            // adiciona um tratador ao evento LimiteSuperiorEvent
            term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
            term.TemperaturaNormalEvent += new TermometroLimite.MeuDelegate(TrataTemperaturaNormal);
            // aumentar a temperatura além do limite term.Aumentar(6);

            term.Aumentar();
            Console.WriteLine(term.ToString());
            
            term.Aumentar(6);
            

            term.Diminuir();
            term.Diminuir(4);

        }

        private static void TrataLimiteSuperior(string msg, double temp)
        {
            Console.Write(msg+" ");
            Console.WriteLine(temp);
        }

        private static void TrataTemperaturaNormal(string msg, double temp)
        {
            Console.Write(msg+" ");
            Console.WriteLine(temp);
        }        
    }
}
