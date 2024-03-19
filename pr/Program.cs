// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
// Tom, Sam, Bobby, Teddy, Jon

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

void FillArray(string[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = InputString("Введите элемент массива: ");
        index++;
    }
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

string[] array1 = new string[Input("Введите размер массива: ")];
FillArray(array1);

int i = 0;
int count = 0;
while (i < array1.Length)
{
    if (array1[i].Length <= 3)
    {
        count++;
    }
    i++;
}

string[] array2 = new string[count]; ;

int k = 0;
int q = 0;
while (k < array1.Length)
{
    if (array1[k].Length <= 3)
    {
        array2[q] = array1[k];
        q++;
    }
    k++;
}

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);