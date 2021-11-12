public class Fogao : IEstadoBinario
{
    public int Bocas { get; private set; }

    public Fogao(int bocas)
    {
        Bocas = bocas;
        Estado = EstadoBinario.Desligado;
    }
    
    public EstadoBinario Estado { get; private set; }

    public void Desligar()
    {
        Estado = EstadoBinario.Desligado;
    }

    public void Ligar()
    {
        Estado = EstadoBinario.Ligado;
    }
}