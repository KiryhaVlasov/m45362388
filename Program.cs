// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// Console.WriteLine("введите первое число");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// int maxNum = 0;
// if (firstNum > secondNum )
// {
//     maxNum = firstNum; 
// }
// else
// {
//     maxNum = secondNum;
// }
// Console.WriteLine($"{maxNum} - наибольшее число");

// Задача 2: Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int thirdNum = Convert.ToInt32(Console.ReadLine());
int maxNum = 0;
if (firstNum > secondNum & firstNum > thirdNum)
{
    maxNum = firstNum; 
}
else if(secondNum > firstNum & secondNum > thirdNum)
{
    maxNum = secondNum;
}
else 
{
    maxNum = thirdNum;
}
Console.WriteLine($"{maxNum} - наибольшее число");