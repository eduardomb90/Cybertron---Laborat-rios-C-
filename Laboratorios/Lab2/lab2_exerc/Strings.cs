using System;

class Strings
{
    public static void TestandoStrings()
    {
        string str = "Hello World!";

        if(str.Equals(string.Empty))
        {
            System.Console.WriteLine("String Vazia...");
        }
        else
        {
            System.Console.WriteLine(str);
        }

        string novaStr = str.Replace("Hello", "Oi");

        System.Console.WriteLine(str);
        System.Console.WriteLine(novaStr);

        string str2 = str;
        str += " How you doing!";

        System.Console.WriteLine(str);
        System.Console.WriteLine(str2);

        string remover = "Hello World!";
        int removerIndex = str.IndexOf("Hello World!");
        string removido = str.Remove(removerIndex, remover.Length);

        System.Console.WriteLine(removido);

        removido = removido.Trim();

        System.Console.WriteLine(removido);
        
        string str3 = "Tenho 2 gatos.";

        System.Console.WriteLine(str3);

        char[] str3Array = str3.ToCharArray();
        int indAnimal = str3.IndexOf("gatos");

        if(indAnimal != -1)
        {
            str3Array[indAnimal++] = 'd';
            str3Array[indAnimal++] = 'o';
            str3Array[indAnimal++] = 'g';
            str3Array[indAnimal++] = 's';
            str3Array[indAnimal++] = ' ';
        }

        System.Console.WriteLine(str3Array);

        if(str.EndsWith('!'))
        {
            System.Console.WriteLine("Termina com '!'");
        } 
    }
}