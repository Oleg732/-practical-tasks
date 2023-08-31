using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность символов");

        var line = Console.ReadLine();

        line.ToCharArray();

        var lineChars = line.ToCharArray();

        var maxCount = 0;

        var index = 0;

        for (int i = 0; i < lineChars.Length; i++)
        {
            if (i + 1 < lineChars.Length)
            {
                if (lineChars[i] != lineChars[i + 1])
                {
                    index++;

                    if (maxCount < index)
                    {
                        
                        maxCount += index == 1 ? maxCount + 2 : maxCount++;
                    }
                }
                else { index = 0; }
            }
        }




    }
}