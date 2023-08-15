/* 
Написать программу, которая из имеющегося массива
 строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/




Console.WriteLine("Введите слова через пробел и нажмите Enter");
string number = Console.ReadLine();

string[] arrayq = StringArrayToArray(number.Split(' '),3);

for (int i = 0; i < arrayq.Length; i++)
{
    Console.WriteLine(arrayq[i]);
}


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
        nyStringArray[0] = $"no shorter than {maxLength} characters found";
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
