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
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Enter 3-digit positive number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int N2 = 0;
// int Mid = 0;
// if (N > 99 && N < 1000)
// {
//     N2 = N % 100;
//     Mid = (N2 - (N2 % 10)) / 10;
//     Console.WriteLine("The second digit is: " + Mid);
// }
// else
// {
//     Console.WriteLine("Retry with 3 digits please");  // прикольно, что вариант "000" тоже попадает сюда
// }

// ---  ---  ---  ---  ---  ---  ---  ---  ---  ---  ---  ---  ---  ---  ---
// мммм, а как сделать этоь решение для вообще любого числа? (о.О )

// Console.Write("Enter any number: ");                    // пусть это будет задачка 10.1
// int N = Convert.ToInt32(Console.ReadLine());            // Может через цикл? Типа делить на 10 пока не станет достаточно двухзначным
// label1:
// if (N < 0)
// {
//     N = N * -1;               
//     goto label1;                                        // уже в самом конце я прочитал про оператор goto (предположение о существовании такого я выдвинул сам
// }                                                       // я искал решение, аналогичное блоксхемам, когда стрелочка ведёт куда мне нужно)
// else                                                    // Однако, в сети многое написано о несовершенстве goto и что, мол, любой код можно накодить и без него.
// {                                                       // И наверняка такое решение есть, но я затупил и не вспомнил как. Если N>0 идём в else и всё ок.  
//     if (N > 9)                                          // а если N<0 то легко делаем его больше - и... что потом?
//     {
//         while (N > 99)       
//         {
//             N = (N - (N % 10)) / 10;
//         }
//         N = N % 10;
//         Console.WriteLine("The second digit is: " + N);
//     }
//     else
//     {
//         Console.WriteLine("we need at least 2 digits");// а ещё потом меня постигло разочарование что с int32 мой мегакод работает только в пределах 10 знаков :(
//     }
// }
//=================================================================================================================================
// Задача 13: Напишите программу, которая выводит третью цифру ПЯТИЗНАЧНОГО числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6                                         ...эмм, ну теперь это не кажется сложным )))

// Console.Write("Enter a positive number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 99 && N < 100000)
// {
//     N = N % 1000;    // пардон, в задачке 10 я за каким-то лешим насоздавал лишних переменных, но не было необходимо. Но переделывать не стал
//     N = (N - (N % 100)) / 100;
//     Console.WriteLine("The third digit is: " + N);
// }
// else
// {
//     Console.WriteLine("There is no third digit here :( ");  // я не стал заморачиваться с отрицательными
// }
//=================================================================================================================================
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет       на данный момент мы её уже разобрали на последнем семинаре, но я попробую по памяти

Console.Write("Enter a day of the week from 1 to 7: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0 && N < 8)
{
    if (N == 6 || N == 7)
    {
        Console.WriteLine("*=-.IT`S A WEEKEND.-=*");
    }
    else
    {
        Console.WriteLine("Go to work :(( ");
    }
}
else
{
    Console.WriteLine("There`s no days with such numbers, lol");
}