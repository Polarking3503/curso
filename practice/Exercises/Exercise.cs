partial class Program
{
    static void exercise()
    {

        string? name = null;
        WriteLine(GetValueOrDefault(name, "Anonymous"));

        int? age = 25;
        WriteLine(GetValueOrDefault(age, 0));

        double? price = null;
        WriteLine(GetValueOrDefault(price, 5.67));
    }

    // For value types: int?, double?, bool?, etc.
    static T GetValueOrDefault<T>(T? value, T defaultValue) where T : struct
    {
        return value ?? defaultValue;
    }

    // For reference types: string?, MyClass?, etc.
    static T GetValueOrDefault<T>(T? value, T defaultValue) where T : class
    {
        return value ?? defaultValue;
    }
}