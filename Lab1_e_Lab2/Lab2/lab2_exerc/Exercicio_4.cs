class Exercicio_4
{
    public static void ConversaoImplicita()
    {
        int i = 10;
        float f = 0;
        f = i; //conversão implícita, sem perda de dados.
        System.Console.WriteLine(f);
        f = 0.5F;
        i = (int) f; //conversão explícita, com perda de dados.
        System.Console.WriteLine(i);

        /*
            É preciso ter cuidado ao fazer conversões, pois quando convertemos de um tipo maior para um menor,
            double para int, por exemplo, temos perda de precisão.
            
                double 0.5 --> (int) casting --> int 0            
        */
    }
}