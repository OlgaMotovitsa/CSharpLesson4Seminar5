// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(4);
PrintArray(arr);
System.Console.WriteLine(SumOdd(arr));


int SumOdd(int[] array)
{;
    int sum = 0;
    for (int i = 1; i < array.Length; i= i+2)
    {
         sum = sum + arr[i];
           
    }
    return sum;  
}


int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine();
}
