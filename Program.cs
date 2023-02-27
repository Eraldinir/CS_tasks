// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first value: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second value: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue == secondValue)
{
    Console.WriteLine(firstValue + " is equal to " + secondValue);
}
else
{
    if (firstValue > secondValue)
    {
        Console.WriteLine(firstValue + " is bigger than " + secondValue);
    }
    else
    {
         Console.WriteLine(secondValue + " is bigger than " + firstValue);
    }
}