// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

string num = number.ToString();
int n = num.Length;

if(n==5) {
    if(num[0]==num[4] && num[1]==num[3]) {
        Console.WriteLine("Yes");
    }
    else {
        Console.WriteLine("No");
    }
}
else{
    Console.WriteLine("Число не пятизначное");
}