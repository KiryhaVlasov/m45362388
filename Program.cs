//Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// Примеры:
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
num = num.Remove(0,1);
num = num.Remove(1,1);
Console.WriteLine(num);