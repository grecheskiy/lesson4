// Дан список некоторых целых чисел, найдите значение 20 в нем и, 
//если оно присутствует, замените его на 200. 
//Обновите список только при первом вхождении числа 20. 
//(можно использовать List<integer> )
//[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]
void ChangeList(List<int> list)
{for (int j=0; j<list.Count; j++)
{if (list[j] == 20) 
{list[j] = 200;
break;}}
Console.WriteLine(string.Join(",", list));}

Console.Write("Enter array size: ");
int k = int.Parse(Console.ReadLine()?? "");
List<int> list = new List<int>(k);
Random rnd = new Random(); 
for (int i=0; i<k; i++)
{list.Add(rnd.Next(1,30));}
Console.WriteLine(string.Join(",", list));
ChangeList(list);