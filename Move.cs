using System;

class Program
{
    static string Move(string str)
    {
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            result += (char)(str[i] + 1);
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine(Move("hello")); 
    }
}
