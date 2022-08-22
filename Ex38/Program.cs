// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble (int size, double min, double max)
{
	double[] array = new double[size];
	Random rnd = new Random();
	
	for (int i = 0; i < size; i++)
	{
		array[i] = Math.Round((rnd.NextDouble()*(max - min) + min), 2);
	}
	return array;
}

double FindMax (double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double[] doubleArray = CreateArrayRndDouble(7, 10.0, 100.0);
Console.WriteLine("[{0}]", string.Join(", ", doubleArray));
double max = FindMax(doubleArray);
double min = FindMin(doubleArray);
Console.WriteLine($"Минимальное значение в массиве = {min}");
Console.WriteLine($"Максимальное значение в массиве = {max}");
Console.WriteLine($"Разница между минимальным и максимальным = {max - min}");
