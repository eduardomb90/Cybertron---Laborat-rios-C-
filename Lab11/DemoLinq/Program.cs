using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
   internal class Program
   {
      static void Main(string[] args)
      {
         List<Pessoa> pessoas = new List<Pessoa>
         {
            new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980,3,14), Casada=true},
            new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978,10,23), Casada=false},
            new Pessoa{Nome="Ana Maria", DataNascimento=new DateTime(1980,3,14), Casada=false},
            new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999,12,12), Casada=true},
            new Pessoa{Nome="Pedro", DataNascimento=new DateTime(1970,5,27), Casada=false},
            new Pessoa{Nome="Huginho", DataNascimento=new DateTime(1970,5,27), Casada=true},
            new Pessoa{Nome="Zezinho", DataNascimento=new DateTime(1980,3,17), Casada=false},
            new Pessoa{Nome="Luizinho", DataNascimento=new DateTime(1990,7,7), Casada=false}
         };

         //Consulta tradiconal
         List<Pessoa> resultado1 = new List<Pessoa>();
         foreach (Pessoa p in pessoas)
         {
            if (p.Casada)
               resultado1.Add(p);
         }
         Console.WriteLine("Pessoas casadas, consulta tradiconal:");

         foreach (Pessoa p in resultado1)
         {
            Console.WriteLine(p.Nome);
         }

         //Consulta LINQ
         var resultado2 = from p in pessoas
                          where p.Casada
                          select p;
         Console.WriteLine("\nPessoas casadas, consulta linq:");

         foreach (Pessoa p in resultado2)
         {
            Console.WriteLine(p.Nome);
         }

         Console.WriteLine("\nPessoas casadas, consulta linq (method syntax):");
         var resultado3 = pessoas.Where(p => p.Casada);

         foreach (Pessoa p in resultado3)
         {
            Console.WriteLine(p.Nome);
         }

         // para obter uma "lista" a partir da consulta linq
         var resultado4 = (from p in pessoas
                           where p.Casada
                           select p).ToList();


         Console.WriteLine("\nPessoas casadas que nasceram após 01/01/1980");
         var resultado5 = (from p in pessoas
                           where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
                           select p).ToList();

         // ups! forçando um pouco a barra...
         resultado5.ForEach(p => Console.WriteLine(p));

         Console.WriteLine("\nProjeção sobre o nome das pessoas casadas");
         var resultado6 = from p in pessoas
                          where p.Casada
                          select p.Nome;

         foreach (String s in resultado6)
         {
            Console.WriteLine(s);
         }

         Console.WriteLine("\nSoteiros em uma lista de objetos anonimos..");
         var resultado7 = (from p in pessoas
                           where !p.Casada
                           select new { p.Nome, p.DataNascimento }).ToList();

         foreach (var elem in resultado7)
         {
            Console.WriteLine(elem.Nome + " " + elem.DataNascimento);
         }

         Console.WriteLine("\nPessoas agrupadas pelo estado civil");
         var resultado8 = from p in pessoas
                          group p by p.Casada;
         foreach (var g in resultado8)
         {
            Console.WriteLine($"casado:{g.Key}");
            foreach (var p in g)
            {
               Console.WriteLine(p);
            }
         }

         Console.WriteLine("\nPessoa mais nova");
         var resultado9 = pessoas.Min(p => p.DataNascimento);
         //Console.WriteLine("Consulta 9:");
         //Console.WriteLine(resultado9);

         var resultado10 = (from p in pessoas
                            where p.DataNascimento == resultado9
                            select p.Nome).ToList();

         resultado10.ForEach(x => Console.WriteLine(x));


         // ------------- Exercicios -------------

         System.Console.WriteLine("\nPessoas ordenadas por mes");
         var resultado11 = pessoas.GroupBy(item => item.DataNascimento.Month)
                              .Select(grp => new { Mes = grp.Key, Pessoa = grp.OrderBy(x => x.DataNascimento) })
                              .OrderBy(grp => grp.Mes);

         foreach (var g in resultado11)
         {
            Console.WriteLine($"{g.Mes}");
            foreach (var p in g.Pessoa)
            {
               System.Console.WriteLine($"{p.Nome} {p.DataNascimento}");
            }
         }


         System.Console.WriteLine("\nA pessoa mais velha");
         var resultado12 = pessoas.GroupBy(p => p.DataNascimento)
                                    .Select(grp => new { Nascimento = grp.Key, Pessoas = grp.OrderBy(x => x.DataNascimento) })
                                    .OrderBy(p => p.Nascimento)
                                    .First().Pessoas;

         foreach (var g in resultado12)
         {
             System.Console.WriteLine($"{g.Nome} {g.DataNascimento}");
         }


         System.Console.WriteLine("\nPessoa solteira mais nova");
         var resultado13 = pessoas.Where(x => x.Casada == false)
                                  .OrderByDescending(x => x.DataNascimento)
                                  .First();
         
         Console.WriteLine($"{resultado13.Nome} {resultado13.DataNascimento}");

         System.Console.WriteLine("\nIdade media");
         var resultado14 = (int) pessoas.Select(x => DateTime.Today.Year - x.DataNascimento.Year)
                                  .ToList()
                                  .Average();

         Console.WriteLine(resultado14);
         
         Console.ReadLine();
      }
   }
}
