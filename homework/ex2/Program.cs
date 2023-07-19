/*Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:     В итоге получается вот такой массив:
1 4 7 2                     7 4 2 1
5 9 2 3                     9 5 3 2
8 4 2 4                     8 4 4 2 */

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);
Console.WriteLine();
SortOfLines(array);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortOfLines(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int tmp = 0; tmp < array.GetLength(1) - 1; tmp++){
                if (array[i, tmp] < array[i, tmp + 1]){
                    int temp = array[i, tmp + 1];
                    array[i, tmp + 1] = array[i, tmp];
                    array[i, tmp] = temp;
                }
            }
        }
    }
}


