using System;

namespace Laboratorio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = { "Eduardo", "Fernando", "Louri", "Guga" };
            Console.WriteLine("Array antes da ordenacao");
            
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            
            Console.WriteLine();
            Array.Sort(lista);

            Console.WriteLine("Array depois da ordenacao");
            
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
        
            Console.WriteLine();
            PessoaDois[] lista2 = {
                new PessoaDois("Jose", 25),
                new PessoaDois("Ana", 28),
                new PessoaDois("Paulo", 20)
            };

            Array.Sort(lista2, new ComparePessoas());
            Console.WriteLine("Array depois da ordenacao");
            
            for (int i = 0; i < lista2.Length; i++)
            {
                Console.Write(lista2[i].Nome + " ");
            }

            Console.WriteLine();
            PessoaTres[] lista3 = {
                new PessoaTres("Jose", 25),
                new PessoaTres("Ana", 28),
                new PessoaTres("Paulo", 20)
            };

            Array.Sort(lista3);
            Console.WriteLine("Array depois da ordenacao");
            
            for (int i = 0; i < lista3.Length; i++)
            {
                Console.Write(lista3[i].Nome + " ");
            }

            Console.WriteLine();
            Array.Sort(lista3);
            Console.WriteLine("Array depois da ordenacao");
            
            for (int i = 0; i < lista3.Length; i++)
            {
                Console.Write(lista3[i].Nome + " ");
            }
        }
    }
}
