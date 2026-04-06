partial class Program
{
    static void HandleNullables()
    {
        //No nilificable
        string firstName = "Carlos";
        //Nulificable
        string? lastname = null;
        Console.WriteLine($"Nombre: {firstName}");

        if (lastname != null)
        {
            Console.WriteLine($"Apellido: {lastname}");
        } else
        {
            Console.WriteLine("Apellido no especificado");
        }
        // Operador de coalescencia nula ??
        Console.WriteLine($"Apellido: {lastname ?? "Apellido no especificado!"}");
        // Operador de acceso nulo seguro .?
        string? text = null;
        Console.WriteLine(text?.Length);
        Console.WriteLine("Sigue ejecutando");
    }
}