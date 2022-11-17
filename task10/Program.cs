// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное трехзначное число = {number}");
int numberA = number/10;
int numberC = numberA%10;
Console.WriteLine($"Вторая цифра данного числа - {numberC}");