// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt (int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();
	
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}

void EvenNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }

    Console.WriteLine($"Количество четных элементов в массиве = {count}");
}

int[] array = CreateArrayRndInt(6, 1, 10);
Console.WriteLine("[{0}]", string.Join(", ", array));
EvenNumbers(array);
