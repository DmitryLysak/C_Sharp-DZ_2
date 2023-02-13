// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7");
int input = int.Parse(Console.ReadLine()!);
if ((input < 1) || (input > 7))
    Console.WriteLine("Ой кто-то не умеет читать, Вы ввели недопустимую цифру");
else
if (input <= 5)
    Console.WriteLine("Нет, это рабочий день");
else
if (input >= 6)
    Console.WriteLine("ДА, это выходной день");