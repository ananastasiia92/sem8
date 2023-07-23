/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();
Console.Write($"Введите размер матрицы: ");
int size = int.Parse(Console.ReadLine());

int[,] array = GetArraySpiral(size);
PrintArray(array);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArraySpiral(int size){
    int[,] array = new int[size, size];
    int val = 0;
    int startX = 0;
    int startY = 0;
    int endX = size -1;
    int endY = size -1;
    while(startX<=endX && startY<=endY){
        for (int i = 0; i <= endY; i++){
            array[startX, i] = val++;
        }
        startX++;
        for (int i = startX; i <= endX; i++){
            array[i,endY] = val++;
        }
        endY--;
        for (int i = endY; i >= startY; i--){
            array[endX,i] = val++;
        }
        endX--;
        for (int i = endX; i >= startX; i--){
            array[i,startY] = val++;
        }
        startY++;
    }
    return array;
}