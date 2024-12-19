
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSort(array);

        Console.WriteLine("Sorted array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
