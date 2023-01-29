//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void FillMass(int[] arr)
{for (int i=0; i<arr.Length; i++)
{int rnd = new Random().Next(-99,99);
arr[i] = rnd;}}

void PrintMass(int[] arr)
{foreach (int item in arr)
Console.Write($"{item} ");}

int sum = 0;
void OddMass(int[] arr)
{for (int j=0; j<arr.Length; j++) 
{if (j % 2 == 1) sum = sum + arr[j];
}Console.Write($" -> {sum}");
Console.WriteLine();    
}

Console.Write("Enter array size: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMass(arr);
PrintMass(arr);
OddMass(arr);