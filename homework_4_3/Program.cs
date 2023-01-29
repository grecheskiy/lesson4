//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void FillMass(int[] arr)
{for (int i=0; i<arr.Length; i++)
{int rnd = new Random().Next(100);
arr[i] = rnd;}}

void PrintMass(int[] arr)
{foreach (int item in arr)
{Console.Write($"{item} ");}}

void MaxMinMass(int[] arr)
{int max = arr.Max();
int min = arr.Min();
int result = max - min;
Console.Write($" -> {result}");
Console.WriteLine();}

Console.Write("Enter array size: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMass(arr);
PrintMass(arr);
MaxMinMass(arr);