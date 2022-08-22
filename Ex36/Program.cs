// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

void EvenSum (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) sum += arr[i];
    }

    Console.WriteLine($"Сумма четных элементов массива = {sum}");
}

int[] array = CreateArrayRndInt(7, 1, 10);
Console.WriteLine("[{0}]", string.Join(", ", array));
EvenSum(array);
