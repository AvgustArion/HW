/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

Console.Clear();
int A = HW("Введите число A: ");
int B = HW("Введите число B: ");
VAR(A, B);
void VAR(int a, int b)
{
    int sum = 1;
    for (int i = 1; i <= b; i++)
    {
        sum = sum * a;
    }
    Console.WriteLine($"A в степени B = {sum}");
}
int HW(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}