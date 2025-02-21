using System;

class Application
{
    static int WordCounter(string text)
    {
        int wordTotal = 0;
        bool insideWord = false;

        for (int position = 0; position < text.Length; position++)
        {
            if (text[position] != ' ')
            {
                if (!insideWord)
                {
                    wordTotal++;
                    insideWord = true;
                }
            }
            else
            {
                insideWord = false;
            }
        }
        return wordTotal;
    }

    static void Main()
    {
        Console.WriteLine(WordCounter("This is a test")); 
    }
}