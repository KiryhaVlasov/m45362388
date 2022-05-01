// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
int maxNum = 0;
if (firstNum > secondNum )
{
    maxNum = firstNum; 
}
else
{
    maxNum = secondNum;
}
Console.WriteLine($"{maxNum} - наибольшее число");