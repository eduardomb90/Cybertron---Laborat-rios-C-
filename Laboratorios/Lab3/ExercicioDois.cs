using System;

public class ExercicioDois
{
    public static void SomaColunasArrayMultiDimensional()
    {
        int[,] matriz = new int[5,5];
        int[] soma = new int[5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i,j] = Convert.ToInt32(i + 1 * Math.Pow(2, j) + i);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write($"{matriz[i,j]} ");
            }
            System.Console.WriteLine("");
        }

        for (int i = 0; i < soma.Length; i++)
        {
            for (int j = 0; j < soma.Length; j++)
            {
                soma[i] += matriz[i,j];
            }
        }
        
        foreach (var item in soma)
        {
            System.Console.WriteLine(item);
        }
    }

    public static void SomaColunasArrayJagged()
    {
        int[][] jagged = new int[5][] { new int[] {1,2,3,4,5},
                                        new int[] {2,4,6,8,10}, 
                                        new int[] {3,6,9,12,15}, 
                                        new int[] {4,8,12,16,20}, 
                                        new int[] {5,10,15,20,25}};
        
        int[] soma = new int[5];

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                System.Console.Write($"{jagged[i][j]} ");
            }
            System.Console.WriteLine("");
        }

        for (int i = 0; i < soma.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                soma[i] += jagged[i][j];
            }
        }
        
        foreach (var item in soma)
        {
            System.Console.WriteLine(item);
        }
    }
}