//=================================================================================================================================
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Enter first value: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second value: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());
// if (firstValue == secondValue)
// {
//     Console.WriteLine(firstValue + " is equal to " + secondValue);
// }
// else
// {
//     if (firstValue > secondValue)
//     {
//         Console.WriteLine(firstValue + " is bigger than " + secondValue);
//     }
//     else
//     {
//          Console.WriteLine(secondValue + " is bigger than " + firstValue);
//     }
// }

//=================================================================================================================================
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Enter 1st value: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter 2nd value: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter 3rd value: ");
// int thirdValue = Convert.ToInt32(Console.ReadLine()); // вводим поочерёдно все 3 значения
// int TEMP = 0; // просто временная переменная, если все 3 числа разные
// int TEMP1e2 = 0; // на случай если 1=2, тогда сравним с 3
// int TEMP1e3 = 0; // на случай если 1=3, тогда сравним с 2
// int TEMP2e3 = 0; // на случай если 2=3, тогда сравним с 1
// if (thirdValue == firstValue && firstValue == secondValue)    // тут я считерил и использовал && c уже следующего семинара, но очень кстати :))
// {    
//     Console.WriteLine(" The MAX are all three equal numbers ");
// }
// else
// {
//     if (firstValue == secondValue)
//     {
//         TEMP1e2 = firstValue; 
//         if (TEMP1e2 > thirdValue)  
//             {
//                 Console.WriteLine(" The MAX are both: " + firstValue + " and " + secondValue);
//             }
//             else
//             {
//                 Console.WriteLine(" The MAX is: " + thirdValue);
//             }
//     }
//     else
//     {
//         if (firstValue == thirdValue) 
//         {
//             TEMP1e3 = firstValue;
//             if (TEMP1e3 > secondValue)  
//             {
//                 Console.WriteLine(" The MAX are both: " + firstValue + " and " + thirdValue);
//             }
//             else
//             {
//                 Console.WriteLine(" The MAX is: " + secondValue);
//             }
//         }
//         else                        
//         {
//             if (secondValue == thirdValue) 
//             {
//                 TEMP2e3 = secondValue;
//                 if (TEMP2e3 > firstValue)  
//                 {
//                     Console.WriteLine(" The MAX are both: " + secondValue + " and " + thirdValue);
//                 }
//                 else
//                 {
//                     Console.WriteLine(" The MAX is: " + firstValue);
//                 }
//             }
//             else
//             {
//                 if (firstValue > secondValue) 
//                 {
//                     TEMP = firstValue;
//                     if (thirdValue > TEMP) 
//                     {
//                     Console.WriteLine(" The MAX is: " + thirdValue);
//                     }
//                     else
//                     {
//                     Console.WriteLine(" The MAX is: " + TEMP);  
//                     } 
//                 }
//                 else
//                 {
//                     TEMP = secondValue;
//                     if (thirdValue > TEMP) 
//                     {
//                     Console.WriteLine(" The MAX is: " + thirdValue);  // Ну и наверное этот код можно сильно облегчить
//                     }
//                     else
//                     {
//                     Console.WriteLine(" The MAX is: " + TEMP);  
//                     } 
//                 }
//             }
//         }
//     }                                                        
// }
//=================================================================================================================================
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Enter number: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// if (Number % 2 == 0)
// {
//     Console.WriteLine("Number " + Number + " is even");  // ноль я посчитал чётным.
// }
// else
// {
//     Console.WriteLine("Number " + Number + " is odd");
// }

//=================================================================================================================================
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Enter N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int evenN = 2;
// if (N < 2)
// {
//     Console.WriteLine("Enter a positive number above 1");
// }
// else
// {
//     while (evenN <= N)
//     {
//         Console.WriteLine(evenN);
//         evenN = evenN + 2;
//     }
// }

//=================================================================================================================================
//=================================================================================================================================