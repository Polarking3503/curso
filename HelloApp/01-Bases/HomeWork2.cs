partial class Program {
    static void DaysOfLife()
    {
        DateTime birthDay = new DateTime(2001, 2, 10);
        TimeSpan difference = DateTime.Now - birthDay;

        Console.WriteLine($"Has vivido {difference.Days} días");
    }
}