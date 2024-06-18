int[] array = { 4, 6, -2, 0, 1, -16, 8, };

for (int j = 0; j < array.Length; j++)
{
    Console.Write($"{array[j]}\t");
}
Console.WriteLine();

Console.WriteLine("Введите число индекса которого надо найти:");
int number = Convert.ToInt32(Console.ReadLine());
int position = -1;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        position = i + 1;
        break;
    }
}

Console.WriteLine($"Позиция: {position}");





