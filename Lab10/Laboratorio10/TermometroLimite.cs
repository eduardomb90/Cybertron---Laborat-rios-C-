public class TermometroLimite : Termometro
{
    private double limiteSuperior;
    private bool disparadoEventoLimiteSuperior;
    public delegate void MeuDelegate(string msg, double temp);
    public event MeuDelegate LimiteSuperiorEvent;
    public event MeuDelegate TemperaturaNormalEvent;

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
                LimiteSuperiorEvent("Atencao: temperatura acima do limite!", this.Temperatura);
                disparadoEventoLimiteSuperior = true;
            }
        }
    }

    private void OnTemperaturaNormalEvent()
    {
        if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
        {
            TemperaturaNormalEvent("Atencao: temperatura esta em niveis normais.", this.Temperatura);
            disparadoEventoLimiteSuperior = false;
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
            OnTemperaturaNormalEvent();
        }
    }
    public override void Diminuir(double quantia)
    {
        base.Diminuir(quantia);
        if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
        {
            OnTemperaturaNormalEvent();
        }
    }

}