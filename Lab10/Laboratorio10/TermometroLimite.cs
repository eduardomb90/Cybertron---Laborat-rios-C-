public class TermometroLimite : Termometro
{
    private double limiteSuperior;
    private bool disparadoEventoLimiteSuperior;
    public delegate void MeuDelegate(string msg);
    public event MeuDelegate LimiteSuperiorEvent;

    public TermometroLimite(double ls)
    {
        limiteSuperior = ls;
        disparadoEventoLimiteSuperior = false;
    }

    public double LimiteSuperior { get { return limiteSuperior; } set{ limiteSuperior = value; } }

    private void OnLimiteSuperiorEvent()
    {
        if((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
        {
            if(LimiteSuperior != null)
            {
                LimiteSuperiorEvent("Atencao: temperatura acima do limite!");
                disparadoEventoLimiteSuperior = true;
            }
        }
    }

    public override void Aumentar()
    {
        base.Aumentar();
        OnLimiteSuperiorEvent();
    }
    public override void Aumentar(double quantia)
    {
        base.Aumentar(quantia);
        OnLimiteSuperiorEvent();
    }

    public override void Diminuir()
    {
        base.Diminuir();
        if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
        {
            disparadoEventoLimiteSuperior = false;
        }
    }
    public override void Diminuir(double quantia)
    {
        base.Diminuir(quantia);
        if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
        {
            disparadoEventoLimiteSuperior = false;
        }
    }

}