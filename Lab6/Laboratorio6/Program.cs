﻿using System;
using System.Collections.Generic;


namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();
            contas.Add(new ContaPoupanca(0.03M, new DateTime(1990,10,23), "Eduardo"));
            contas.Add(new ContaCorrente(0.02M, "Eduardo"));

            contas.ForEach(conta => {
                conta.Depositar(200);
                System.Console.WriteLine(conta.Saldo);
                conta.Sacar(50);
                System.Console.WriteLine(conta.Saldo);

                if(conta is ContaPoupanca)
                {
                    System.Console.WriteLine("Vai render?");
                    ContaPoupanca cp = conta as ContaPoupanca;
                    cp.AdicionarRendimento();
                    System.Console.WriteLine(conta.Saldo);
                }

                if(conta is ContaCorrente)
                {
                    System.Console.WriteLine("Pagar taxa?");
                    ContaCorrente cc = conta as ContaCorrente;
                    cc.CobrarTaxa();
                    System.Console.WriteLine(conta.Saldo);
                }
            });
        }
    }
}

/*
    Em uma coleção do tipo Conta, só é possível chamar os métodos das subclasses que estão declarados na classe mãe (Conta).
    Por isso, foi necessário fazer uma conversão para poder chamar os métodos específicos de cada classe.
*/
