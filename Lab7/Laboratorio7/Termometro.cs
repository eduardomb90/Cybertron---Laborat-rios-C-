public class Termometro
{
    private double _temperatura;

    public Termometro()
    {
        _temperatura = 0.0;
    }

    public double Temperatura
    {
        get
        {
            return _temperatura;
        }
    }

    public void Aumentar(double temp)
    {
        _temperatura += temp;
    }
    public void Diminuir(double temp)
    {
        _temperatura -= temp;
    }
}