// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArray(int size)
{
int[] array = new int[15];
for(int i=0;i<array.Length; i++){
  array[i] = new Random().Next(1,100); //  array[i] = new Random().Next(); 
   }
return array;
}
int[] array = FillArray(15);
Console.WriteLine($"[" + string.Join(",", array) +"]");

       int num = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i% 2 == 1)
    {
        num = num + array[i];
    }
}
  Console.WriteLine( num);