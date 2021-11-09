using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
           byte b;
           b = byte.MaxValue;
           System.Console.WriteLine($"Valor maximo de byte: {b}");

           int i;
           i = int.MaxValue;
           System.Console.WriteLine($"Valor maximo de int: {i}");

           long l;
           l = long.MaxValue;
           System.Console.WriteLine($"Valor maximo de long: {l}");

           System.Console.WriteLine("-------------------------------------------");

           string strPrimeira   = "Alo ";
           string strSegunda    = "Mundo";

           string strTerceira   = strPrimeira+strSegunda;

           System.Console.WriteLine(strTerceira);

           int cchTamanho = strTerceira.Length;

           string strQuarta = $"Tamanho {cchTamanho.ToString()}";
           System.Console.WriteLine(strQuarta);

           System.Console.WriteLine(strQuarta.Substring(0,5));

           System.Console.WriteLine("-------------------------------------------");

           DateTime dt = new DateTime(2021, 11, 08);

           string strQuinta = dt.ToString();

           System.Console.WriteLine(strQuinta);

        }
    }
}
