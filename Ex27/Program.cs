﻿// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumber(int number)
{
    
 int counter = Convert.ToString(number).Length;
 int advance = 0;
 int result = 0;

 for (int i = 0; i < counter; i++){
 advance = number - number % 10;
 result = result + (number - advance);
 number = number / 10;
    }
 return result;
  }

Console.Write("   Введите число ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Сумма цифр равна {0}", SumNumber(number));