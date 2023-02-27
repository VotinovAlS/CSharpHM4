// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray (int[] a)
{
  int length = a.Length;
  int i = 0;
  while(i<length)
  {
    a[i] = new Random().Next (1,8);
    i++;
  }
}

void PrintArray(int[] a)
{
  int length = a.Length;
  int i = 0;
  while (i<length)
  {
    Console.WriteLine (a[i]);
    i++;
  }
}

int[] a = new int [8];
FillArray(a);
PrintArray(a);
