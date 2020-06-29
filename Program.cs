using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class MainClass
{

    public static string LetterChanges(string str)
    {
        char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a' ,'b', 'c', 'd','e','f','g','h','i','j','k','l','m','n','o','p', 'q','r','s','t','u','v','w','x','y','z'};
        List<Char> word = new List<Char>();
        Regex pattern = new Regex("[;,\t\r ]|[\n]{2}");
        pattern.Replace(str, "");

        foreach (char s in str)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if(s.ToString().Contains(' '))
                {
                    word.Add(' ');
                    break;
                }   
                else if (s.ToString().Contains(alphabet[i]))
                {

                    try
                    {
                        word.Add(alphabet[i+1]);

                    }
                    catch (Exception)
                    {
                        word.Add(alphabet[0]);
                    }
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