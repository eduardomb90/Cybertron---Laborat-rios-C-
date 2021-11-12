public class Computador : IEstadoBinario
{
    public EstadoBinario Estado { get; private set; }

    public Computador()
    {
        Estado = EstadoBinario.Desligado;
    }

    public void Desligar()
    {
        Estado = EstadoBinario.Desligado;
    }

    public void Ligar()
    {
        Estado = EstadoBinario.Ligado;
    }
}