﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите пятизначное число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пятизначное число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int power = A;
for (int i = 1; i < B; i++)
{
  power = power * A;
}
Console.WriteLine("Число " + A + " в степени " + B + " равно: " + power);
