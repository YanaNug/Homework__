﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i=1; A > 0 || A<0; i++){
   sum = sum + A % 10;
   A /=10;
}
 Console.Write($"Сумма цифр в введенном числе равна " + sum);