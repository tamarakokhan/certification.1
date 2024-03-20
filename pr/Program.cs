// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string InputString(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string[] CreateArray(string text)
{
    string[] array = new string[Input(text)];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = InputString("Введите элемент массива: ");
        index++;
    }
    return array;
}

string[] NewArray(string[] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
        i++;
    }

    string[] newArray = new string[count]; ;

    int k = 0;
    int q = 0;
    while (k < array.Length)
    {
        if (array[k].Length <= 3)
        {
            newArray[q] = array[k];
            q++;
        }
        k++;
    }
    return newArray;
}

void PrintArray(string[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write(array[index] + "\t");
        index++;
    }
}

string[] initialArray = CreateArray("Введите размер массива: ");

Console.Write("Первоначальный массив: ");
PrintArray(initialArray);
Console.WriteLine();
Console.Write("Новый массив: ");
PrintArray(NewArray(initialArray));