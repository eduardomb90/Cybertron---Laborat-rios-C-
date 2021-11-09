using System;

class Data
{
    public string NomePessoa { get; private set; }
    public DateTime NascimentoPessoa { get; private set; }
    public int Idade { get; private set; }
    
    
    public Data(string nome, string nascimento)
    {
        DateTime nasc;
        if(DateTime.TryParse(nascimento, out nasc))
        {
            if(ValidaData(nasc))
                NascimentoPessoa = nasc;            
        }
        
                
    }

    private bool ValidaData(DateTime nasc)
    {
        bool maior = false;

        DateTime hoje = DateTime.Today;
        int idade = hoje.Year - nasc.Year;

        if(hoje.Month < nasc.Month || (hoje.Month == nasc.Month && hoje.Day < nasc.Day))
            idade--;

        if(idade >= 18)
            Idade = idade;
            maior = true;

        
        return maior;
    }


    
    public static void TestandoMetodosDeDateTime()
    {
        DateTime data = new DateTime();

        System.Console.WriteLine(data);

        DateTime data2 = DateTime.Now;

        System.Console.WriteLine(data2);

        var data3 = "08/11/20211";

        DateTime data_3; 
        
        if(DateTime.TryParse(data3, out data_3))
        {
            System.Console.WriteLine(data_3);
        }
        else
        {
            System.Console.WriteLine("Algo deu errado.");
        }

        var utc = DateTime.UtcNow;
        System.Console.WriteLine(utc);
        var diasNoMes = DateTime.DaysInMonth(2021, 11);
        System.Console.WriteLine(diasNoMes);

        DateTime dt = new DateTime(2019,09,1);

        var dt_2 = dt.AddDays(-1);
        System.Console.WriteLine(dt);
        System.Console.WriteLine(dt_2);

        dt_2 = dt.AddDays(1);
        System.Console.WriteLine(dt);
        System.Console.WriteLine(dt_2);
        
    }
}