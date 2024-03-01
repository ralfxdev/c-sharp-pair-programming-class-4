int n = 0;
Random random = new Random();
int randomNumber = random.Next(1, 101);

do
{
    try
    {
        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine()!);

        if (n == randomNumber)
        {
            Console.WriteLine($"Adivinaste el numero random -> {n}");
            break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
} while (n != randomNumber);
