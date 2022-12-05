/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();
int lenth = MAS("Ввведите длинну массива: ");
int[] random = new int[lenth];
for (int i = 0; i < random.Length; i++)
{
    random[i] = new Random().Next(1,9);
    Console.Write(random[i] + " ");
}
int MAS(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}