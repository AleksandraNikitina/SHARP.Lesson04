// Input from console a string with letters and digits.
// Create a new string with letters from the sourse string.

string GetLettersFromString(string s)
{
    string letters ="";
    foreach(char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

Console.Write("Enter string with letters and digits: ");
string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);