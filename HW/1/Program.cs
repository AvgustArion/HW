/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string aStr = Console.ReadLine();
int a = Convert.ToInt32(aStr);

Console.WriteLine("Введите второе число");
string bStr = Console.ReadLine();
int b = Convert.ToInt32(bStr);

if ( a > b)
{
    Console.WriteLine("max = " + (a));
} else {
Console.WriteLine("max = " + (b));  
}