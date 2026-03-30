partial class Program
{
    static void ShowStringType()
    {
        string name = "Juan";
        string message = "Hola " + name;
        string interpolateMessage = $"Hola {name}";

        Console.WriteLine(message);
        Console.WriteLine(interpolateMessage);
        Console.WriteLine($"Tu nombre tiene {name.Length} palabras");
        Console.WriteLine($"Tu nombre en mayúsculas es {name.ToUpper()}");
        Console.WriteLine($"Tu nombre en minúsculas es {name.ToLower()}");

        int number = 13;
        Console.WriteLine(number.ToString());

        bool isString = true;
        Console.WriteLine(isString.ToString());
    }
}