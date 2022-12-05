/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.Clear();
int number = JE("Введите число: ");

int lenth = numberlenth(number);
SumNumbers(number, lenth);
int numberlenth(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int num, int lenth)
{
    int sum = 0;
    for (int i = 1; i <= lenth; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine($"Cумма цифр числа {number} = {sum}");
}
int JE(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}