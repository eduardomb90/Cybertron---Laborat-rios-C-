public interface IEstadoBinario
{
    void Ligar();
    void Desligar();

    EstadoBinario Estado { get; }    
}