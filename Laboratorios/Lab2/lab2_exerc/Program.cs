using System;

namespace lab2_exerc
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Numeros.TiposNumericos();
            //Strings.TestandoStrings();
            //Data.TestandoMetodosDeDateTime();
            Data eduardo = new Data("Eduardo", "23/10/1990");
            System.Console.WriteLine(eduardo.NascimentoPessoa);
            System.Console.WriteLine(eduardo.Idade);
            //Exercicio_4.ConversaoImplicita();
            //Exercicio_5.TestandoConversoes();
            //Exercicio_6.TestandoTryParse();
            //Exercicio_7.PerdendoPrecisao();
            //Exercicio_8.TestandoCW();
        }
    }
}
