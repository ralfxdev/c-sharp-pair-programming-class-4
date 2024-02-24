int n = 1;

while (true)
{
    try
    {
        if (n % 7 == 0 && n % 11 == 0)
        {
            Console.WriteLine($"El primer numero positivo entre 7 y 11 es {n}");
            break;
        }

        n++;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
}


