// Считать с консоли строку, состоящую из латинских букв в нижнем регистре.
// Выяснить, сколько среди введённых букв гласных.

using System.Reflection;

int CountVowels(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count ++;
            }
        }
    }
    return count;
}

// Or second way:

// int CountVowels(string str)
// {
//     string vowels = "aeiouy";
//     int count = 0;
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (vowels.Contains(str[i]))
//         {
//             count ++;
//         }
//     }
//     return count;
// }

Console.WriteLine("Enter string");
string str = Console.ReadLine();
int result = CountVowels(str);
Console.WriteLine($"String contains {result} vowels letters.");
