for (int i = 1; i < 10; i++)
{
    try
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
}
