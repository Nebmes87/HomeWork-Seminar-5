
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] MyArray = new int[10];
for (int i = 0; i < MyArray.Length; i++ )
  {
    MyArray[i] = new Random().Next(1, 10);
    Console.Write(MyArray[i] + " ");
  }

int maxNumber = MyArray[0];
int minNumber = MyArray[0];

  for (int i = 1; i < MyArray.Length; i++)
  {
    if (maxNumber < MyArray[i])
    {
      maxNumber = MyArray[i];
    }
        if (minNumber > MyArray[i])
    {
      minNumber = MyArray[i];
    }
  }

int result = maxNumber - minNumber;

Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами: {result}");

// или

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
int DifferenceOfElements(int[] array)
{
    int maxNumber = array[0];
    int minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
        {
        if (maxNumber < array[i])
        {
        maxNumber = array[i];
        }
        if (minNumber > array[i])
        {
        minNumber = array[i];
        }
    }
    int result = maxNumber - minNumber;
    return result;  
}

int[] numbers = new int[10];
FillArray(numbers);
WriteArray(numbers);
DifferenceOfElements(numbers);
System.Console.WriteLine("Разница между минимальным и максимальным элементами = "+DifferenceOfElements(numbers));