using System;

class Exercicio_8
{
    public static void TestandoCW()
    {
        int x = 10;
        double y = 3.4;
        Console.WriteLine("{0} {1}",x,y);
        /*
            Esta sobrecarga do WriteLine, recebe uma string indexida, 
            e um array de argumentos, que iram substituir os seus indices na string, com os seus valores.

            Algo como -->   WriteLine(string texto, params object?[] args)
        */
    }
}