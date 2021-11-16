using System;

public class PessoaTres : IComparable<PessoaTres>
{
    private string meuNome;
    private int minhaIdade;
    private static bool idadeNome = false;
    
    public PessoaTres(string n, int i)
    {
        meuNome = n;
        minhaIdade = i;
    }
    public string Nome
    {
        get { return meuNome; }
    }
    public int Idade
    {
        get { return minhaIdade; }
        set { minhaIdade = value; }
    }

    public int CompareTo(PessoaTres outro)
    {
        if(idadeNome)
        {
            idadeNome = !idadeNome;
            return meuNome.CompareTo(outro.meuNome);
        }    

        idadeNome = !idadeNome;
        return minhaIdade.CompareTo(outro.minhaIdade);
    }
}