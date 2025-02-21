using System;

class Application
{
    static bool CheckVowel(char letter)
    {
        char[] vowelList = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        for (int index = 0; index < vowelList.Length; index++)
        {
            if (letter == vowelList[index])
                return true;
        }
        return false;
    }

    static string GetFirstVowels(string input, int targetCount)
    {
        string output = "";
        int vowelTally = 0;

        for (int position = 0; position < input.Length; position++)
        {
            if (CheckVowel(input[position]))
            {
                output += input[position];
                vowelTally++;
                if (vowelTally == targetCount)
                    return output;
            }
        }
        return "invalid";
    }

    static void Main()
    {
        Console.WriteLine(GetFirstVowels("sharpening skills", 3)); 
    }
}