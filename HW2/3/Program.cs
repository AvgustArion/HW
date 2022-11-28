/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
if (number == 1){
    Console.WriteLine("Будни");
}if (number == 2){
    Console.WriteLine("Будни");    
}if (number == 3){
    Console.WriteLine("Будни");    
}
if (number == 4){
    Console.WriteLine("Будни");    
}
if (number == 5){
    Console.WriteLine("Будни");    
}
if (number == 6){
    Console.WriteLine("Выходной");    
}
if (number == 7){
    Console.WriteLine("Выходной");    
} if (number > 7){
    Console.WriteLine("Ввели не день недели");
}