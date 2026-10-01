class Calculadora : Icalculadorabase, IcalculadoraAvancada
{

    int a = 2;
    int b = 25;
    
    public double cos()
    {
        Console.WriteLine("Calculando cosseno");
        return 0;
    }

    public double seno()
    {
        Console.WriteLine("Calculando seno");
        return 0;
    }

    public double tan()
    {
        Console.WriteLine("Calculando tangente");
        return 0;
    }

    double Icalculadorabase.divisao()
    {
       return (double)a/b;
    
    }

    double Icalculadorabase.multiplicacao()
    {
        return (double)a*b;
    }

    double Icalculadorabase.soma()
    {
        return (double)a+b;
    }

    double Icalculadorabase.subtracao()
    {
        return (double)a-b;
    }
}