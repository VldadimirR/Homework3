// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine($"Введите  координату точки А:");
double dotAx = Convert.ToDouble(Console.ReadLine());
double dotAy = Convert.ToDouble(Console.ReadLine());
double dotAz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите  координату точки B:");
double dotBx = Convert.ToDouble(Console.ReadLine());
double dotBy = Convert.ToDouble(Console.ReadLine());
double dotBz = Convert.ToDouble(Console.ReadLine());


double dotD = Math.Sqrt(Math.Pow((dotAx) - (dotBx),2) + Math.Pow((dotAy) - (dotBy), 2) + Math.Pow((dotAz) - (dotBz), 2));
dotD = (Math.Round(dotD, 2));
Console.WriteLine($"Расстояние между точками в 3D пространстве равно: {dotD}");