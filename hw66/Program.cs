﻿/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void FromMtoN(int num)
{

    if (M <= num)
    {
        Console.Write($"{M} ");
        sum = sum + M;
        M++;
        FromMtoN(num);
       
}
   
    else
    {
        Console.WriteLine();
         Console.WriteLine($"Сумма чисел равна {sum}");
    }
}

FromMtoN(N);