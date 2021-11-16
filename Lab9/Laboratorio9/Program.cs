using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> listaStrings = new List<string>(); 
            listaStrings.Add("Um"); 
            listaStrings.Add("Hello"); 
            listaStrings.Add("World"); 
            Console.WriteLine(listaStrings[0]);
            Console.WriteLine(listaStrings[1]); 
            Console.WriteLine(listaStrings[2]);
            
            System.Console.WriteLine(); 
            
            //listaStrings.Add(10); --> Erro ao tentar adicionar um int em uma lista de strings.

            // FILA ------- First in -> First out

            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".Net Framework / Core");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            System.Console.WriteLine();

            Queue<int> minhaFila = new Queue<int>(); 
            minhaFila.Enqueue(10); 
            minhaFila.Enqueue(200); 
            minhaFila.Enqueue(1000);
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue()); 
            Console.WriteLine(minhaFila.Dequeue());

            System.Console.WriteLine();

            // PAR CHAVE E VALOR ------------------------------

            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";
            Console.WriteLine("O código 55 é: {0}", paises[55]);
            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }

            
            System.Console.WriteLine("------- EXERCICIOS -------");

            //1. Como fazer para recuperar o código DDI a partir do nome de um país no exemplo de uso do Dicionário?
            
            var key = paises.FirstOrDefault((pais) => pais.Value.Equals("França")).Key;
            System.Console.WriteLine(key);

            System.Console.WriteLine();


            //2. Dada uma lista de números reais, implemente um método TotalAcimaMedia, para calcular e retornar o
            //  número de elementos da lista cujos valores são maiores do que a média de todos os elementos.

            List<double> reais = new List<double>();
            double[] numeros = {23,56,10,2,172,64,5,10,92,41,1,1234};
            reais.AddRange(numeros);

            System.Console.WriteLine($"Numeros acima da media: {TotalAcimaMedia(reais)}");

            
            System.Console.WriteLine();

            //3. Você consegue imaginar uma forma de retornar uma nova lista com esses valores, ao invés de apenas
            //  retornar o número de elementos? Crie o método ListaAcimaMedia.

            Console.Write("Lista de numeros acima da media: ");
            ListaAcimaMedia(reais).
                ForEach(delegate (double x){ 
                    Console.Write($"{x} "); 
                });
        }

        public static int TotalAcimaMedia(List<double> reais)
        {
            int total = 0;

            var avg = reais.Average();
            System.Console.WriteLine($"Media: {avg}");

            total = reais.Where(x => x > avg).Count();

            return total;
        }

        public static List<double> ListaAcimaMedia(List<double> lista)
        {
            var avg = lista.Average();
            
            return lista.Where(x => x > avg).ToList();
        }
    }
}
