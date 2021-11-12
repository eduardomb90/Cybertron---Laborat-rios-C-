public class Lampada : IEstadoBinario
{
    private bool _ligado;
    private int _voltagem;
    private int _potencia;

    public Lampada(int voltagem, int potencia)
    {
        _ligado = false;
        this._voltagem = voltagem;
        this._potencia = potencia;
    }

    public EstadoBinario Estado
    {  
        get
        {            
            if(_ligado)
                return EstadoBinario.Ligado;
            else
                return EstadoBinario.Desligado;
        }
    }

    public void Desligar()
    {
        _ligado = false;
    }

    public void Ligar()
    {
        _ligado = true;
    }
}