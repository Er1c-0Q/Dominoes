class Dominó
{

private int d1;
private int d2;

public Dominó(int d1, int d2)
{
    this.d1 = d1;
    this.d2 = d2;
}

public void Imprime()
{
    Console.WriteLine($"{d1},{d2}");
}

public static int operator +(Dominó a, Dominó b)
{
    int suma= a.d1 + a.d2 + b.d1 + b.d2;
    return suma;
}

    private static void Main(string[] args)
    {
        Dominó d1= new Dominó(0,1);
        Dominó d2= new Dominó(2,3);

        int total= d1+d2;

        System.Console.WriteLine(total);

    }
}