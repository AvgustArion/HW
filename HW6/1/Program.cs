/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/

Console.Clear();
Console.Write("Введите числа через запятую: ");
int[] numbers = NumNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] NumNum(string inpute)
{
    int count = 1;
    for (int i = 0; i < inpute.Length; i++)
    {
        if (inpute[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < inpute.Length; i++)
    {
        string temp = "";

        while (inpute [i] != ',')
        {
        if(i != inpute.Length - 1)
        {
            temp += inpute [i].ToString();
            i++;
        }
        else
        {
            temp += inpute [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}