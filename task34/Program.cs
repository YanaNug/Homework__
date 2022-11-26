// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] FillArray(int size)
{
int[] array = new int[8];
for(int i=0;i<array.Length; i++){
  array[i] = new Random().Next(100, 1000);
   }
return array;
}
int[] array = FillArray(8);
Console.WriteLine($"[" + string.Join(",", array) +"]");
int count=0;

for(int i = 0; i < array.Length; i++)
{
    int num = array[i];
    if(num % 2 == 0){
        count++;
    }
}
Console.WriteLine($"Kоличество чётных чисел в массиве: " + count);