using MyLib;

string[] strings = new string[5] { "hello", "world", "hel", "wor", "123" };
string[] result = new string[strings.Length];
int count = 0;

Console.WriteLine("Заданный массив строк:");
MyLibClass.PrintArray(strings);

for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        result[count] = strings[i];
        count++;
    }
}

Console.WriteLine("Полученный массив строк:");
MyLibClass.PrintArray(result);
