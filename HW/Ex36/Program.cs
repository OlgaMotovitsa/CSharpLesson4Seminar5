//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//   минимальным элементов массива.
// [3 7 22 2 78] -> 76



int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(GetMaxNum(arr));
System.Console.WriteLine(GetMinNum(arr));

int GetMaxNum(int[] array) 

{
    int result = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > result)
        {
            result = array[i];
        }
    }
    return result;
}


int GetMinNum(int[] array)
{
    int result = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < result)
        {
            result = array[i];
        }
    }
    return result;
}


int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-20, 21);
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

int result = (GetMaxNum(arr)) - (GetMinNum(arr));
System.Console.WriteLine(result);
