using System;
using System.Text;

namespace ConsoleApp30
{
    public static void CapitalLetter(this string text)
    {
        StringBuilder metn = new StringBuilder();
        text = text.Trim().ToLower();

        metn.Append(char.ToUpper(text[0]));


        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                metn.Append(text[i]);
                metn.Append(char.ToUpper(text[i + 1]));
                i++;
            }
            else
            {
                metn.Append(text[i]);
            }
        }
        Console.WriteLine(metn);
        Console.ReadLine();
    }
}
