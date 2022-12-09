// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int Sum (int n,int m){
if (n==m) {
        int sum = 0;
        return sum;
    }
    else{
        n++;
        int sum = n + Sum(n,m);
        return sum;
    }
}

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(n-1,m));
