// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность двумерного массива m x n");
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
arr[i,j] = new Random().Next(0,36);
Console.Write(arr[i,j] + " ");
}
Console.WriteLine();
}

Console.WriteLine();

Console.Write("Введите  i: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите  j: ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows < arr.GetLength(0) && colums < arr.GetLength(1)){
    Console.WriteLine($"На данной позиции находится элемент: " + arr[rows, colums]);
}
else Console.WriteLine($"[{rows},{colums}] -> элемента с таким индексом в массиве не существует");