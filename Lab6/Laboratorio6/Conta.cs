public abstract class Conta
{
    private decimal saldo;
    protected string titular;

    public decimal Saldo { get{ return saldo; } protected set { saldo = value; } }
    public string Titular { get{ return titular; } }
    public abstract string Id{ get; }

    public Conta(string t)
    {
        titular = t;
    }


    public virtual void Depositar(decimal valor)
    {
        saldo += valor;
    } 
    public virtual void Sacar(decimal valor)
    {
        saldo -= saldo;
    }
}