// Задайте строку символов (тип char[]). Создайте строку из символов этого массива.
// Указание: конструктор строки вида string(char[]) не использовать.

string CharArrayToString(char[] arr)
{
    string res = "";
    // string res = string.Empty;    то же самое, что строкой выше

    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}


char[] array = { 'a', 'b', 'c', ',', 'e', 'f' };

string result = CharArrayToString(array);
Console.WriteLine(result);