String pass = "jutiapa";
String userPass = "";

do
{
    try
    {
        Console.WriteLine("Ingrese la contraseña: ");
        userPass = Console.ReadLine()!;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ups, hubo un error: " + ex.Message);
    }
} while (userPass != pass);

Console.WriteLine($"Bienvenido al sistema!");