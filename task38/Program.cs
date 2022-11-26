// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine($"Введите вещественное число(с разделителем , ):");
double[] array = new double[5];
for(int i=0;i<array.Length; i++)
{
  array[i] = Convert.ToDouble(Console.ReadLine()) ;
}

Console.WriteLine($"[" + string.Join(" ", array) +"]");


double maxValue = array.Max();
Console.WriteLine($"Максимальное значение массива = " + maxValue);

double minValue = array.Min();
Console.WriteLine($"Минимальное значение массива = " + minValue);

double num = maxValue - minValue;
Console.WriteLine($"Разница max и min = " + num);