using System;

class Application
{
    static bool CheckOrder(string text)
    {
        for (int position = 0; position < text.Length - 1; position++)
        {
            if (text[position] > text[position + 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine(CheckOrder("abc"));     
        Console.WriteLine(CheckOrder("edabit"));  
    }
}