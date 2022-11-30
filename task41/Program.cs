// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива:");
int[] array = new int[n];

for(int i=0;i<array.Length; i++)
{
  array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[" + string.Join(", ", array) +"]"); 

int count = 0;

for(int i = 0; i < array.Length; i++)
{
    int num = array[i];
    if(num > 0){
        count++;
    }
}
Console.WriteLine($"Kоличество чисел больше 0: " + count);