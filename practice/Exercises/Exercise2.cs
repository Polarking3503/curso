partial class Program
{
    static void Exercise2()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        //Last number
        WriteLine($"Last: {numbers[^1]}");

        // Range from index 2 to 5
        int[] fromIndexTo = numbers[2..5];
        WriteLine($"Range [2..5]: {string.Join(", ", fromIndexTo)}");

        int[] reversedNumbers = numbers.Reverse().ToArray();
        
        // Full reverse
        WriteLine($"Reverse numbers: {string.Join(", ", reversedNumbers)}");

        // First of reverse numbers 
        WriteLine($"First of reversed: {reversedNumbers[0]}");

        // Last of reverse numbers
        WriteLine($"Last of reversed: {reversedNumbers[^1]}");

    }
}