/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] initArray()
{
    Random rnd = new Random();
    int size =rnd.Next(4,10);
    int[] result = new int[size];
    
    for (int i =0; i< result.Length;i++)
    {
        result[i]=rnd.Next(-99,100);
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i =0; i< arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int SumElementsOddPosition(int[] array)
{
    int sum=0;
    for (int i=1;i<array.Length;i+=2)
    {
        sum+=array[i];
    }
    return sum;
}
int [] result =initArray();
PrintArray(result);
int sumElements=SumElementsOddPosition(result);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетной позиции = {sumElements}");
