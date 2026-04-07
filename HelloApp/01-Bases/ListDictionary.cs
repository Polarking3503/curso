partial class Program
{
    static void ListDictonary()
    {
        List<string> names = new List<string>{"Ana", "Carlos", "Juan"};
        names.Add("Lucia");
        Console.WriteLine($"Total de nombre: {names.Count}");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");
        Console.WriteLine($"¿Ana está en la lista? {isPresent}");

        //Dictionary
        Dictionary<int,string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Felipe"},
            {3, "Elena"}
        };

        Console.WriteLine($"El estudiante con el ID 1 es: {students[1]}");

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }
    }
}