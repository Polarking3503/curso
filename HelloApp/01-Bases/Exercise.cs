partial class Program
{
    static void SalaryCalculator()
    {
        Console.WriteLine("Calculadora de salario");

        Console.WriteLine("Ingrese su nombre: ");
        string? inputUserName = Console.ReadLine();

        Console.WriteLine("Ingrese las horas trabajadas: ");
        int horasTrabajadas = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el salario por hora: ");
        decimal salarioPorHora = decimal.Parse(Console.ReadLine() ?? "0");
        
        decimal salarioTotal = horasTrabajadas * salarioPorHora;

        Console.WriteLine($"El salario para {inputUserName} es de: {salarioTotal}");
    }
}