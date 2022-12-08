﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillMatrix(int rows, int columns, int length)
{
int[,,] matrix = new int [rows, columns, length];
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
    for(int k = 0; k < matrix.GetLength(1); k++)
    {
        matrix[i,j,k] = new Random().Next(10,100);
    }
}
}
return matrix;
}

void PrintMatrix(int[,,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
    for(int k = 0; k < matrix.GetLength(1); k++){
         if(matrix[i,j,k] != matrix[i,j,k])
         {
            Console.Write(matrix[i,j,k] + " ");
        }
    }
}
}
}

int [,,] matrix = FillMatrix(2,2,2);
FillMatrix(2,2,2);
PrintMatrix(matrix);


void PrintIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
PrintIndex(matrix);