// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] arr = { 2, 4, 0, 1, 9 };
int target = 9;
int result = LinearSearch(arr, target);

if (result != -1)
{
    Console.WriteLine($"Element found at index {result}");
}
else
{
    Console.WriteLine("Element not found in the array");
}

static int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return i;
        }
    }

    return -1;
}