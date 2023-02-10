// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int limit = 2;
if (input.Length <= limit)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine("Третья цифра этого числа " + input[2]);

