using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente("Eduardo", 0);
            System.Console.WriteLine(minhaConta.SaldoMedio());
            System.Console.WriteLine($"Conta criada em: {minhaConta.DataCriacao}");
            minhaConta.Depositar(100);
            System.Console.WriteLine(minhaConta.SaldoMedio());
            minhaConta.Sacar(50);
            System.Console.WriteLine(minhaConta.SaldoMedio());
            minhaConta.Depositar(300);
            System.Console.WriteLine(minhaConta.SaldoMedio());
            minhaConta.Sacar(150);
            System.Console.WriteLine(minhaConta.SaldoMedio());
            minhaConta.Depositar(400);
            System.Console.WriteLine(minhaConta.SaldoMedio());
            minhaConta.Sacar(50);
            System.Console.WriteLine(minhaConta.SaldoMedio());

            System.Console.WriteLine(minhaConta.Saldo);
        }
    }
}
