partial class Program
{
    static void Operators()
    {
        int number = 12;
        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 10;

        if(isEven && isGreaterThanTen)
        {
            Console.WriteLine($"EL número {number} es par y mayor que 10");
        } else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"EL número {number} es impar y mayor que 10");
        } else
        {
            Console.WriteLine($"EL número {number} no cumple con las condiciones");
        }

        // Operador ternario (?:)
        int age = 15;
        string category = age > 18 ? "Adulto" : "Menor";
        Console.WriteLine(category);
    }
}