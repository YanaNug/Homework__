// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()) ;
int count (int n)
{
    if (n/10!=0)
        return 1+count(n/10);
    else
        return 1;
}

Console.WriteLine($"Количество цифр в числе " + n + " равняется " + count(n));