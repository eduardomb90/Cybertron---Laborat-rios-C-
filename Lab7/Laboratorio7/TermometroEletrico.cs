public class TermometroEletrico : Termometro, IEstadoBinario
{
    private bool ligado = false;

    public EstadoBinario Estado
    {
        get
        {
            if(ligado)            
                return EstadoBinario.Ligado;
            else
                return EstadoBinario.Desligado;
            
        }
    }

    public void Desligar()
    {
        ligado = false;
    }

    public void Ligar()
    {
        ligado = true;
    }
}