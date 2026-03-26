partial class Program
{
    static void ShowNumericTypes()
    {
        var integerNumber = 42m;
        double doubleNumber = 3.1416d;
        float floatingNumber = 274f;
        long longNumber = 300_200_100L;
        decimal monetaryNumber = 99.99m;

        Console.WriteLine($"Entero {integerNumber}, Double {doubleNumber}, Float {floatingNumber}, Long {longNumber}, Decimal {monetaryNumber}");
    }
}