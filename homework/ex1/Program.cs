/* Задача 59. Из двумерного массива целых числел удалить строку и столбец,
на пересечении которых расположен наименьший элемент

1 2 3 6 7         1 2 6 7 
1 5 7 3 9   ->    1 5 3 9 
9 5 2 9 2         9 5 9 2 
3 5 0 2 7         3 5 2 7 */

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}
PrintArray(array);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] positionSmallElement = new int[1, 2];
positionSmallElement = MinElement(array, positionSmallElement);
Console.Write($"Позиция элемента:  ");
PrintArray(positionSmallElement);

int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
DeleteLines(array, positionSmallElement, arrayWithoutLines);
PrintArray(arrayWithoutLines);


int[,] MinElement(int[,] array, int[,] position)
{
  int temp = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] <= temp)
      {
        position[0, 0] = i;
        position[0, 1] = j;
        temp = array[i, j];
      }
    }
  }
  Console.WriteLine($"Mинимальный элемент: {temp}");
  return position;
}

void DeleteLines(int[,] array, int[,] min, int[,] arrayWithoutLines)
{
  int k = 0, l = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (min[0, 0] != i && min[0, 1] != j)
      {
        arrayWithoutLines[k, l] = array[i, j];
        l++;
      }
    }
    l = 0;
    if (min[0, 0] != i)
    {
      k++;
    }
  }
}
