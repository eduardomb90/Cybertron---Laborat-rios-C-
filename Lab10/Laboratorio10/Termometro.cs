public class Termometro
{
    private double valor;

    public Termometro()
    {
        valor = 0.0;
    }

    public double Temperatura { get { return valor; } set { valor = value; } }
    
    public virtual void Aumentar()
    {
        valor += 0.1;
    }
    public virtual void Aumentar(double quantia)
    {
        valor += quantia;
    }

    public virtual void Diminuir()
    {
        valor -= 0.1;
    }
    public virtual void Diminuir(double quantia)
    {
        valor -= quantia;
    }

    public override string ToString()
    {
        return valor.ToString();
    }

}