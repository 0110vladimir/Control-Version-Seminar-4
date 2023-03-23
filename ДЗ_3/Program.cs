/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые) */


int Size = Input("Задайте размер массива: ");
int min = Input("Задайте нижнюю границу диапазона чисел массива: ");
int max = Input("Задайте верхнюю границу диапазона чисел массива: ");
int[] array = GetRandomArray(Size, min, max);
PrintArray(array);

// Метод создания массива случайных чисел
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int Input(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
} 

// Метод вывода массива
void PrintArray(int[] array)
{
    Console.WriteLine("Элементы массива: ");
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}