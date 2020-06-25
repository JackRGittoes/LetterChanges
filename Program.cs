using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class MainClass
{

    public static string LetterChanges(string str)
    {

        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        List<Char> word = new List<Char>();
        Regex pattern = new Regex("[;,\t\r ]|[\n]{2}");
        pattern.Replace(str, "");

        var counter = 0;
        foreach(char x in alphabet)
        {
            counter++;
            if (str.ToUpper().Contains(x))
            {
                
                try
                {
                    word.Add(alphabet[counter++]);
                }
                catch(Exception)
                {
                    word.Add(alphabet[0]);  
                }
            }
        }

        str = new string(word.ToArray());
        return str;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(LetterChanges(Console.ReadLine()));
    }

}