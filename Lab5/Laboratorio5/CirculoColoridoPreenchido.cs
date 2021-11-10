using System.Drawing;

public class CirculoColoridoPreenchido : CirculoColorido
{
    private Color minhaCor;

    public CirculoColoridoPreenchido(double x, double y, double r, string c, string cor) : base(x, y, r, c)
    {
        minhaCor = System.Drawing.Color.FromName(cor);
    }

    public void ImprimeCor()
    {
        
    }

    public override string ToString()
    {
        byte g = minhaCor.G;
        byte b = minhaCor.B;
        byte r = minhaCor.R;
        byte a = minhaCor.A;

        return base.ToString() + $" cor= {minhaCor} R = {r} G = {g} B = {b} A = {a}";
    }   
}