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

        /*
            Cada tipo numerico tem um valor limite que consegue guardar.
            Um inteiro por exemplo, so consegue guardar um numero que possa ser representado em 32bits (4 bytes).

                No caso de uint (sem numeros negativos) 2^32 = 4.294.967.296

                Ja o ulong, de 64bits (sem sinal), 2^64 = 18.446.744.073.709.551.616
            
            Sendo assim, uma string de valor 999999999999999999999999..... nao pode ser convertida para nenhum tipo numerico do C#,
            pois nenhum deles consegue guardar este valor, pois eh muito grande.
        */ 
    }
}