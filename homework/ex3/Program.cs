﻿/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
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

void Sumes(int[,]array){

    int minJ = 0;
    int minJsum =0;
    int SumJ = 0;

    for (int i = 0; i < array.GetLength(1); i++){
        minJ = minJ + array[0, i];

    for (i = 0; i < array.GetLength(0); i++){
        
        for (int j = 0; j < array.GetLength(1); j++){
            SumJ = SumJ + array[i, j];
            
            if (SumJ < minJ)
            {
            minJ = SumJ;
            minJsum = i;
            }
            SumJ = 0;
        }
    }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {minJsum + 1} строка"); 
}
Sumes(array);