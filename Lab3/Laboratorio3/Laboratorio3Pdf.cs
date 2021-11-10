using System;

public class Laboratorio3Pdf
{
    public static void ArrayInteiro()
    {
        int[] array = new int[5] {10,20,30,40,50};

        int i = 0;
        foreach(var item in array)
        {
            System.Console.WriteLine($"Indice = {i} & Valor = {item}");
            i++;
        }
        
        // for (int i = 0; i < array.Length; i++)
        // {
        //     System.Console.WriteLine($"Indice = {i} & Valor = {array[i]}");
        // }
    }

    public static void ArrayString()
    {
        string[] str = new string[3];
        str[0] = "Um";
        str[1] = "Dois";
        str[2] = "Tres";
        
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("Indice = " + i + " & Valor = " + str[i]);
        }
    }

    public static void ArrayDateTime()
    {
        DateTime[] dt = new DateTime[2];
        
        dt[0] = new DateTime(2002, 5, 1); 
        dt[1] = new DateTime(2002, 6, 1);
        
        for (int i = 0; i < 2; i++)
        {
            System.Console.WriteLine("Indice = " + i + " & Data = " + dt[i].ToShortDateString());
        }
    }
}