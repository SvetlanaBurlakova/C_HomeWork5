/* Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76 */
int DiffMinMaxArray(int[]array)
{
int min=array[0];
int max =array[0];
for (int i=1; i<array.Length;i++)
{
    if (array[i]<min) min = array[i];
    if (array[i]> max) max = array[i];
}
return max-min;
}
Console.WriteLine("Введите массив через запятую:");
string str =Console.ReadLine();
string [] arrayStr = str.Split(',');
int [] array =new int[arrayStr.Length];

for (int i=0;i<arrayStr.Length;i++) array[i]=Convert.ToInt32(arrayStr[i]);

int diffResult =DiffMinMaxArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diffResult}");
