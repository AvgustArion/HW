/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int a = number % 100;
int b = a / 10;
Console.WriteLine(b);
