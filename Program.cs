//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите число: ");
string? num = string.Empty;
do
{
    num = Console.ReadLine();
} 
while (num.Length < 3 || num.Length > 3);

Console.WriteLine($"Вторая цифра числа {num} = {num[1]}");