using System;

public class ContaCorrente : Conta 
{
    public decimal Taxa { get; private set; }
    public DateTime DataAbertura { get; private set; }
    
    public ContaCorrente(decimal taxa, string titular) : base(titular)
    {
        Taxa = taxa;
        DataAbertura = DateTime.Now;
    }

    public override string Id => $"{this.Titular} (CC)";

    public override void Depositar(decimal valor)
    {
        base.Depositar(valor);
    } 
    public override void Sacar(decimal valor)
    {
        this.Saldo -= valor + (valor * 0.02M);
    }

    public void CobrarTaxa()
    {
        DateTime hoje = DateTime.Today;
        DateTime fimDoMes = new DateTime(hoje.Year, hoje.Month, DateTime.DaysInMonth(hoje.Year, hoje.Month));
        
        if(DateTime.Compare(hoje, fimDoMes) == 0)
            Saldo -= Saldo * Taxa;
        
        Saldo -= 1M;
    }
}