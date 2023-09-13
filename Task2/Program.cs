internal class Program
{
    public static string ToNotation(int n, int notation)
    {
        var ternaryNumber = string.Empty;

        while (n > 0)
        {
            ternaryNumber = (n % notation) + ternaryNumber;
            n /= notation;
        }

        return ternaryNumber;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число в десятичой системе");

        var num = Console.ReadLine();

        Console.WriteLine("Введите основание новой ситемы [2...20]");

        var notation = Console.ReadLine();

        var retVal = ToNotation(int.Parse(num), int.Parse(notation));

        Console.WriteLine($"Результат: {retVal}");
    }
}