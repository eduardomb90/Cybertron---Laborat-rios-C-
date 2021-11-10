using System;

public class ContaPoupanca : Conta
{
    private decimal taxaJuros;
    private DateTime dataAniversario;


    public ContaPoupanca(decimal j, DateTime dateTime, string t) : base(t)
    {
        taxaJuros = j;
        dataAniversario = dateTime;
    }

    public override string Id => $"{this.Titular} (CP)";

    public decimal Juros { get{ return taxaJuros; } set{ taxaJuros = value; } }
    public DateTime DataAniversario => dataAniversario;

    public void AdicionarRendimento()
    {
        DateTime hoje = DateTime.Now;
        if(hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
        {
            decimal rendimento = this.Saldo * taxaJuros;
            this.Depositar(rendimento);
        }
        Saldo += 1M;
    }

    public override void Depositar(decimal valor)
    {
        base.Depositar(valor);
    } 
    public override void Sacar(decimal valor)
    {
        this.Saldo -= valor + (valor * 0.05M);
    }
}