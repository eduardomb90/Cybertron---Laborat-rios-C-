using System;

public class ContaCorrente
{
    private decimal _acumulador;
    private int _numeroDeOperacoes;    
    public decimal Saldo { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public string NomeTitular { get; private set; }

    public ContaCorrente(string nomeTitular) : this(nomeTitular, 0)
    {

    }

    public ContaCorrente(string nomeTitular, decimal val)
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
}