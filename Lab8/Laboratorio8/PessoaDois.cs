public class PessoaDois
{
    private string meuNome;
    private int minhaIdade;
    
    public PessoaDois(string n, int i)
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
}