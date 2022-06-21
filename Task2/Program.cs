// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

int RandomNumbers(int numberElements, int min, int max)
{
int[] randomNumbers = new int[numberElements];
int sumElements = 0;
Console.Write("Получившийся массив: ");

for (int i = 0; i <randomNumbers.Length; i++ )
{
    randomNumbers[i] = new Random().Next(min, max);

    Console.Write(randomNumbers[i] + " ");

    if (i % 2 != 1)
    {
    sumElements = sumElements + randomNumbers[i];
    }
}
    return sumElements;
}

Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 
int randomNumbers =  RandomNumbers(numberElements, 1, 10);
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

// или

int Prompt(string message)
{
    System.Console.Write(message);
    string num = Console.ReadLine();
    return int.Parse(num);
}
void FillArray(int[] array)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(1, 100);
  }
}
void WriteArray(int[] array)
{
  for (int i = 0; i<array.Length; i++ )
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}
int SumOddElement(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1)
        {
        sum = sum + array[i];
        }
    }
    return sum;
}

int num = Prompt("Введите количество элементов массива: ");
int[] numbers = new int[num];
FillArray(numbers);
WriteArray(numbers);
SumOddElement(numbers);
System.Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " +SumOddElement(numbers));