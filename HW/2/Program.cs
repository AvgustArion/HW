/* 
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string aStr = Console.ReadLine();
int a = Convert.ToInt32(aStr);

Console.WriteLine("Введите второе число");
string bStr = Console.ReadLine();
int b = Convert.ToInt32(bStr);

Console.WriteLine("Введите третье число");
string cStr = Console.ReadLine();
int c = Convert.ToInt32(cStr);

int max = 0;

if ((a > b) && (a > c))
{
    max = a;
} else
if ((b > a) && (b > c))
{
    max = b;
} else
if ((c > a) && (c > b))
{
    max = c;
}
Console.WriteLine(max);