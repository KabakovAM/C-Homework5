// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateFillArrayDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return array;
}

double CompareMinMax(double[] array)
{
    double result = 0;
    int indexMin = 0;
    int indexMax = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[indexMin] > array[i]) indexMin = i;
        if (array[indexMax] < array[i]) indexMax = i;
    }
    result = array[indexMax] - array[indexMin];
    return result;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

double[] arr = CreateFillArrayDouble(10, -100, 100);
double result = CompareMinMax(arr);
Console.WriteLine("Разница между максимальным и минимальным элементом массива ");
Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(arr);
Console.ResetColor();
Console.Write(" равна ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(result);
Console.ResetColor();