//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void FillMass(int[] arr)
{for (int i=0; i<arr.Length; i++)
{int num = new Random().Next(100,999);
arr[i] = num;}}

void PrintMass(int[] arr)
{Console.Write("[");
foreach (int item in arr) 
{Console.Write($"{item}, ");}}
int count1 = 0;

void EvenMass(int[] arr) 
{foreach (int ev in arr){
if (ev % 2 == 0) {count1++;}
}Console.Write($"] -> {count1}");
Console.WriteLine();}

Console.Write("Enter array size: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMass(arr);
PrintMass(arr);
EvenMass(arr);