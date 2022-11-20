// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите A по оси х");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A по оси у");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A по оси z");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B по оси x");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B по оси y");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B по оси z");
int bz = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
// Console.WriteLine(Math.Round(result, 2));
Console.WriteLine($"Расстояние между точками в 3D пространстве равняется" + " " + Math.Round(result, 2));