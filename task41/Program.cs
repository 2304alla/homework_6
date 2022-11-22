// Задача 41: Пользователь вводит с клавиатуры M чисел
// Посчитайте, сколько чисел больше 0 ввёл пользователь.



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int CounterNumber(int[] array)

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] FillingArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

Console.Write("Задвйте колличество элементов массива: ");
int sizeNum = Convert.ToInt32(Console.ReadLine());

int[] arr = FillingArray(sizeNum);
PrintArray(arr);

int counter = CounterNumber(arr);
Console.WriteLine();

Console.WriteLine($"Чисел больше 0 --> {counter} ");
