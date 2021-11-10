using System;

namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            System.Console.WriteLine($" x = {circ1.CentroX} y = {circ1.CentroY}");
            
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            System.Console.WriteLine($" x = {circ2.CentroX} y = {circ2.CentroY}");
            
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            System.Console.WriteLine($" x = {circ3.CentroX} y = {circ3.CentroY}");
            
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
            System.Console.WriteLine($" x = {circ4.CentroX} y = {circ4.CentroY}");

            CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido(1.5, 3.1, 1, "Red", "Blue");
            Console.WriteLine(circ5);
            System.Console.WriteLine($" x = {circ5.CentroX} y = {circ5.CentroY}");
            circ5.ImprimeCor();

            Circulo[] circulos = new Circulo[] {
                new Circulo(4.4, 2, 4),
                new CirculoColorido(2.5, 3.3, 3, "verde"),
                new CirculoColoridoPreenchido(1.2, 2.1, 1, "amarelo", "Red")
            };

            foreach (var circulo in circulos)
            {
                System.Console.WriteLine(circulo);
            }
        }
    }
}
