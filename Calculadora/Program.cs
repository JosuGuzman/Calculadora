class Calculadora
{
    public int A { get; set; }
    public int B { get; set; }

    public Calculadora(int a, int b)
    {
        A = a;
        B = b;
    }

    public int Sumar()
    {
        if (A < 0 || B < 0)
        {
            Console.WriteLine("No se pueden sumar números negativos.");
            return 0;
        }
        else
            return A + B;
    }

    public int Restar()
    {
        if (A < B || A < 0 || B < 0)
        {
            Console.WriteLine("Para restar, el primer número no puede ser menor que el segundo ni negativo.");
            return 0;
        }
        else
            return A - B;
    }

    public int Multiplicar()
    {
        if (A <= 0 || B <= 0)
        {
            Console.WriteLine("No se pueden multiplicar números negativos.");
            return 0;
        }
        else
            return A * B;
    }

    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Calculadora calc = new Calculadora(a, b);

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma: {calc.Sumar()}");
        Console.WriteLine($"Resta: {calc.Restar()}");
        Console.WriteLine($"Multiplicación: {calc.Multiplicar()}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}