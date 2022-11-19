// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите значение координат х первой точки:");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координат у первой точки:");
var y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координат z первой точки:");
var z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координат х второй точки:");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координат у второй точки:");
var y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координат z второй точки:");
var z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));

Console.WriteLine(result);
