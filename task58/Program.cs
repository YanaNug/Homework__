// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность матриц:");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int [,] arr = new int [m,n];
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
arr[i,j] = new Random().Next(0,10);
Console.Write(arr[i,j] + " ");
}
Console.WriteLine();
}

Console.WriteLine();


int [,] array = new int [m,n];
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
array[i,j] = new Random().Next(0,10);
Console.Write(array[i,j] + " ");
}
Console.WriteLine();
}

Console.WriteLine();

int [,] matrix = new int [m,n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            matrix[i, j] += arr[i, k] * array[k, j];
        }
      Console.Write(matrix[i,j] + " ");  
    }
}