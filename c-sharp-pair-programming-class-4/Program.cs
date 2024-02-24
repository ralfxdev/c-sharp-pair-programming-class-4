int n;
int result = 0;

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("Ingrese un numero entero: ");
        n = int.Parse(Console.ReadLine()!);
        result = result + n;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
}

Console.WriteLine($"La suma de los 10 numero enteros es {result}");