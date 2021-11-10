using System;

public class ContaCorrente
{
    private decimal _acumulador;
    private int _numeroDeOperacoes;    
    public decimal Saldo { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public string NomeTitular { get; private set; }
    
    public ContaCorrente(string nomeTitular, decimal val = 0)
    {
        if(val > 0)
            Depositar(val);
        
        NomeTitular = nomeTitular;
        DataCriacao = DateTime.UtcNow;
    }

    public void Depositar(decimal val)
    {
        Saldo += val;
        _acumulador += Saldo;
        _numeroDeOperacoes++;
    }

    public void Sacar(decimal val)
    {
        Saldo -= val;
        _acumulador += Saldo;
        _numeroDeOperacoes++;
    }

    public decimal SaldoMedio(){
        if(_numeroDeOperacoes > 0)
            return _acumulador/_numeroDeOperacoes;

        return Saldo;
    }

    public static void ExerciciosUmDoisTres()
    {
        ContaCorrente minhaConta = new ContaCorrente("Eduardo", 400);
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

/*
    1. Altere a classe ContaCorrente de forma que ela possua atributos para armazenar a data de criação da conta e o nome do titular. 
    O nome do titular deve ser informado como parâmetro do construtor. A data de criação deve ser gerada no momento da inicialização (DateTime.Now). Crie também propriedades 
    de acesso a estes atributos.

    2. Altere a classe ContaCorrente de maneira que ela seja capaz de armazenar o saldo médio do correntista. Para tanto, cada vez que os métodos de depósito ou retirada forem 
    acionados o saldo da conta, depois da operação, deve ser acumulado e um contador deve ser incrementado. O saldo médio é obtido dividindo-se este acumulador pelo número de 
    operações realizadas.
*/