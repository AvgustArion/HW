/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

Console.Clear();
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write("{0}", arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine("]");
}

void Array(int[] arrayToFill, int diviation)
{
    for (int i = 0; i < arrayToFill.Length; i++)
        arrayToFill[i] = new Random().Next(-diviation, diviation + 1);
}

void CloneArray(int[] arrayToCopy, int[] arrayToFill)
{
    for (int i = 0; i < arrayToCopy.Length; i++)
        arrayToFill[i] = arrayToCopy[i];
}


int arraySize = 0;

arraySize = new Random().Next(5, 20);
int[] firstArray = new int[arraySize];
int[] secondArray = new int[arraySize];
Array(firstArray, 20);
CloneArray(firstArray, secondArray);
Console.Clear();

Console.WriteLine("Первый массив:");
PrintArray(firstArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Копия первого массива:");
PrintArray(secondArray);