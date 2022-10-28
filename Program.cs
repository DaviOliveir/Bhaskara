
double a, b, c, delta, x1, x2;


Console.WriteLine("Equação do Segundo Grau \n");

Console.Write("(a): ");

a = Convert.ToDouble(Console.ReadLine());


Console.Write("(b): ");


b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c): ");

c = Convert.ToDouble(Console.ReadLine());
if (a == 0)
{  
    Console.WriteLine("esse número não condiz com uma equação de segundo grau!  por favor digite outro número");
}

else
{
    delta = b * b -4 * a * c;

    if (delta < 0)

    {
      Console.WriteLine($"como delta é == {delta:N2}, a equação não possui raizes reais!");
    
    }
    else
    {
        x1 = -b + Math.Sqrt (delta);
        x2 = -b - Math.Sqrt (delta);
        Console.WriteLine($"x1 = {x1} e x2 = {x2}");
    }
}



