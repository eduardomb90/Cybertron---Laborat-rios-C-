using System;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            IEstadoBinario[] lista = new IEstadoBinario[4];
            lista[0] = new Lampada(110, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            lista[2] = new Computador();
            lista[2].Ligar();
            lista[3] = new Fogao(6);

            for (int i = 0; i < lista.Length ; i++)
            {
                Console.WriteLine(lista[i].Estado);
            }
        }
    }
}
