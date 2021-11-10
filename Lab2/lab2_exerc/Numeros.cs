    using System;
        
    class Numeros
    {
        public static void TiposNumericos()
        {
            double maxD     = double.MaxValue;
            float maxF      = float.MaxValue;
            decimal maxDec  = decimal.MaxValue;

            System.Console.WriteLine(maxD);
            System.Console.WriteLine(maxF);
            System.Console.WriteLine(maxDec);
            
            double dividendo = 23;
            double resultado = dividendo/2;

            int inteiro = 10;
            double n1 = (double) inteiro;

            System.Console.WriteLine(resultado);
            System.Console.WriteLine(n1.GetType());            
        }
    }
    