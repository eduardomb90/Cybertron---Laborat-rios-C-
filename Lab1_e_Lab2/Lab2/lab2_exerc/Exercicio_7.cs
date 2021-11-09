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

        /*
            A classe Convert nos ajuda na conversao, apesar de ainda perdermos precisao, eh melhor do que fazer uma conversao direta
            usando o casting (int), pois, no caso da classe Convert o numero eh arredondado para baixo ou para cima.
            Diferente do que ocorre no casting, onde simplesmente perdemos a casa decimal.

                0.6 --> 0 (casting)
                0.6 --> 1 (Convert)
        */
    } 
}