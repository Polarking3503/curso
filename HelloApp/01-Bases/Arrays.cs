using System.Globalization;

partial class Program
{
    static void Arrays()
    {
        int [] numbers = new int [5];
        numbers [0] = 1;
        numbers [1] = 3;
        // Directa
        int [] numbersArray = [5, 10, 15, 20, 25, 30];
        Console.WriteLine($"Primer elemento {numbersArray[0]}");
        Console.WriteLine($"Tercer elemento {numbersArray[2]}");
        // Tamaño del arreglo
        Console.WriteLine($"El número de elementos es: {numbersArray.Length}");
        // Desde el final del arreglo ^
        Console.WriteLine($"Último elemento {numbersArray[^1]}");
        Console.WriteLine($"Penúltimo elemento {numbersArray[^2]}");
        // Rangos para obtener subarreglos ..
        int [] firstThree = numbersArray[..3];
        int [] fromIdexTo = numbersArray[2..];

        foreach(var number in fromIdexTo)
        {
            Console.WriteLine(number);
        }
    }
}