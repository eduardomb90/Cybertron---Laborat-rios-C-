using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Laboratorio3Pdf.ArrayDateTime();
            Laboratorio3Pdf.ArrayInteiro();
            Laboratorio3Pdf.ArrayString();
            
            System.Console.WriteLine();
            
            ExercicioUm.CopiaArray();
            
            System.Console.WriteLine();

            ExercicioDois.SomaColunasArrayMultiDimensional();
            ExercicioDois.SomaColunasArrayJagged();

        }
    }
}
