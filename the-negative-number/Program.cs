int n = 0;
int result = 0;

do{
    try
    {
        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine()!);
        result = result + n;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
} while (n >= 0);

Console.WriteLine($"La suma de los numero enteros es {result}");