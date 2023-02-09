/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int [] initArray()
{
    Random rnd = new Random();
    int size =rnd.Next(4,10);
    int[] result = new int[size];
    
    for (int i =0; i< result.Length;i++)
    {
        result[i]=rnd.Next(100,1000);
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
int CountEvenNumbers(int[] array)
{
    int count=0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]%2==0) count+=1;
    }
    return count;
}
int [] result =initArray();
PrintArray(result);
int countEvenNum=CountEvenNumbers(result);
Console.WriteLine($"Количество четных чисел в массиве = {countEvenNum}");
