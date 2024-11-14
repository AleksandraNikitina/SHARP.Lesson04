// На основе символов строки (тип string) сформировать 
// массив символов (тип char[]). Вывести массив на экран.

// Указание: Метод строки ToCharArray() не использовать.

char[] StringToCharArray (string s)
{
    char[] arrStr = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        arrStr[i] = s[i];
    }
    return arrStr;
}

void PrintCharArray(char[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"'{array[i]}',");
    }
        Console.WriteLine("'" + array[array.Length-1] + "'}");
        Console.WriteLine();
}

Console.Write("Enter string: ");
string str = Console.ReadLine();

char[] result = StringToCharArray(str);
PrintCharArray(result);