// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

int Sum(int A)
{
  int i = 1;
  int number = A;
  int sum = 0;
  while (number / 10 > 0)
  {
    i++;
    number /= 10;
  }
  for (int n = 0; n < i; n++)
  {
    sum = sum + A % 10;
    A /= 10;
  }
  return sum;
}
int sum = Sum(A);
Console.WriteLine(sum);