using System;

public class ExercicioUm
{
    public static void CopiaArray()
    {
        int[] arrayUm, arrayDois;

        arrayUm     = new int[10];
        arrayDois   = new int[10];
        
        for (int i = 0; i < arrayUm.Length; i++)
        {
            arrayUm[i] = Convert.ToInt32(i + Math.Pow(i,2) * 3);
        }

        //arrayUm.CopyTo(arrayDois, 0);
        //  ou
        //arrayDois = (int[]) arrayUm.Clone();
        //  ou
        for (int i = 0; i < arrayUm.Length; i++)
        {
            arrayDois[i] = arrayUm[i];
        }

        foreach(var item in arrayUm)
        {
            System.Console.WriteLine(item);
        }

        foreach(var item in arrayDois)
        {
            System.Console.WriteLine(item);
        }

    }

    
}