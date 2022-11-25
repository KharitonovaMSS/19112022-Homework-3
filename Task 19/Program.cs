// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
var num = Convert.ToInt32(Console.ReadLine());
var num1 = (num % 10);
var num2 = ((num % 100) / 10);
var num4 = ((num % 10000) / 1000);
var num5 = (num / 10000);

if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("Число является паллиндромом");
}
else
{
    Console.WriteLine("Число не является паллиндромом");
}