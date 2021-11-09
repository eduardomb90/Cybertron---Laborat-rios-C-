using System;

class Exercicio_7
{
    public static void PerdendoPrecisao()
    {
        double valorFracionado = 4.7;
        int valorInteiro1 = (int) valorFracionado;
        int valorInteiro2 = Convert.ToInt32(valorFracionado);
        Console.WriteLine($"Conversao explicita = {valorInteiro1}");
        Console.WriteLine($"Conversao metodo Convert = {valorInteiro2}");

        double valor2 = 6.4;
        int valor_2 = Convert.ToInt32(valor2);
        System.Console.WriteLine($"Conversao metodo Convert = {valor_2}");

        System.Console.WriteLine("A conversao pelo metodo Convert usar as funcoes piso e teto, da matematica.");
    } 
}