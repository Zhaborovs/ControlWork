/* 
Написать программу, которая из имеющегося массива
 строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам.           +
Первоначальный массив можно ввести с клавиатуры,       +
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/




Console.WriteLine("введите массив строк через пробел и нажмите Enter");
string string0 = Console.ReadLine();
string[] array2 = StringArrayToArray(string0.Split(' '));
Console.WriteLine("------------->");
PrintArrayString(array2);
//вывод массива строк в кансоль
void PrintArrayString(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
//создание нового массива из старого по ограничению в длине символов (3)
string[] StringArrayToArray(string[] array, int maxLength = 3)
{
    int nyArrLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            nyArrLength++;
        }
    }

    string[] nyStringArray = new string[nyArrLength];
    if (nyArrLength == 0)
    {
        return nyStringArray;
    }

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            nyStringArray[j] = array[i];
            j++;
        }
    }
    return nyStringArray;
}
