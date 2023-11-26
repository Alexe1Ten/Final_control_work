// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] EnteringDataIntoAnArray (int lenArr)
{
    string[] arrayString = new string[lenArr];
    for (int i = 0; i < lenArr; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента: ");
        arrayString[i] = Console.ReadLine();
    }
    return arrayString;
}

string[] SortedArray (string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    string[] sortedArray = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            sortedArray[j] = arr[i];
            j++;
        }
    }
    return sortedArray;
}

void PrintArray (string[] arr)
{
    Console.Write("[\"{0}\"]", string.Join("\", \"", arr));
}


Console.WriteLine("Сколько будет элементов в массиве?");
int length = Convert.ToInt32(Console.ReadLine());

string[] introductoryArray = EnteringDataIntoAnArray(length);

PrintArray(introductoryArray);
Console.Write(" -> ");
PrintArray(SortedArray(introductoryArray));

