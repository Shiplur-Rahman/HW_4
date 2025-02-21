using System;

class Application
{
    static string SwapEnds(string input)
    {
        if (input.Length < 2)
            return "Incompatible.";

        if (input[0] == input[input.Length - 1])
            return "Two's a pair.";

        char[] characters = new char[input.Length];

        // Transfer characters to array
        for (int position = 0; position < input.Length; position++)
        {
            characters[position] = input[position];
        }

        // Exchange first and last characters
        char temporary = characters[0];
        characters[0] = characters[input.Length - 1];
        characters[input.Length - 1] = temporary;

        // Build result string
        string result = "";
        for (int index = 0; index < characters.Length; index++)
        {
            result += characters[index];
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine(SwapEnds("hello")); // Output: "oellh"
    }
}