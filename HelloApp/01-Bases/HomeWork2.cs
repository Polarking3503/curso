using System.Globalization;

partial class Program
{
    // static void DaysOfLife()
    // {
    //     DateTime birthDay = new DateTime(2001, 2, 10);
    //     TimeSpan difference = DateTime.Now - birthDay;

    //     Console.WriteLine($"Has vivido {difference.Days} días");
    // }

    // 🏆 Ejercicio:
    // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
    // Consideraciones:
    // - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
    //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
    // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
    // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
    //   sumando un año para calcular la fecha del próximo (opcional).
    static void DaysUntilNextBirthday()
    {
        Console.Write("Introduce tu fecha de nacimiento (dd/mm/yyyy): ");
        string dayBirthay = Console.ReadLine()!;

        DateTime birthday = DateTime.ParseExact(dayBirthay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthday = new DateTime(currentDate.Year, birthday.Month, birthday.Day);

        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
            TimeSpan timeUntilNextBirthday = nextBirthday - currentDate;

            Console.WriteLine($"Faltan {timeUntilNextBirthday.Days} días para tu próximo cumpleaños.");
        }
        else
        {
            Console.Write("Feliz cumpleaños!");
        }
    }
}