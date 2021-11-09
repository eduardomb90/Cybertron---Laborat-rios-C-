using System;

class Exercicio_5
{
    public static void TestandoConversoes()
    {
        string stringInteiro = "123456789";
        int valorStringInteiro = Convert.ToInt32(stringInteiro);
        Console.WriteLine(valorStringInteiro);
        Int64 valorInt64 = 123456789;
        int valorInt = Convert.ToInt32(valorInt64);
        Console.WriteLine(valorInt);

        double valorD = 14.5;
        int valorInteiro = Convert.ToInt32(valorD);
        System.Console.WriteLine(valorInteiro); // Ha perda de precisao.


        System.Console.WriteLine(Decimal.MaxValue);
        string stringInteiroGrande = "999999999999999999999999999999999999999999999";
        decimal valorStringInteiroGrande; 
        var resultado = Decimal.TryParse(stringInteiroGrande, out valorStringInteiroGrande) ? "Sucesso" : "Falhou";
        System.Console.WriteLine(resultado); 
    }
}