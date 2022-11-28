/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите трёхзначное число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int a = number % 10;
if (number < 100) {
    Console.Write("Ввели не трёхзначное число");
} else {
    Console.WriteLine(a);
}