/* написать программу, которая из имеющегося массива строк формирует массив строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести к клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
ПРИМЕР:
["hello", "2", "world", ":-)"] -> ["2",":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []*/

string[] str = { "hello", "2", "world", ":-)"};
Console.WriteLine("Исходный массив строк: ");
for (int i = 0; i < str.Length; i++)
Console.Write(str[i] + " ");
Console.WriteLine("\n");

string[] str2 = new string[str.Length];

void SortFillNewString(string[] str, string[] str2)
{
    if(str.Length == 0)
    {
        Console.WriteLine("Задан пустой массив строк");
    }
    else
    {
    int count = 0;
    bool flag = false;
    for (int i = 0; i < str.Length; i++)
    {
    if(str[i].Length <= 3)
        {
        str2[count] = str[i];
        count++;
        flag = true;
    }
    }
    if (flag == false)
    {
    Console.WriteLine("В исходном массиве не обнаружены подходящие строки!");
    }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Новый массив строк (длина строки<=3): ");
SortFillNewString(str, str2);
PrintArray(str2);


