using System.Collections.Generic;

public class ComparePessoas : IComparer<PessoaDois>
{
    public int Compare(PessoaDois x, PessoaDois y)
    {        
        if (x.Idade > y.Idade)
            return 1;
      
        if (x.Idade < y.Idade)
            return -1;
        
        return 0;
    }
}