static int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
        {
            return mid;
        }
        if (arr[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return -1;
}

// Sample call
int[] arr = { 0, 1, 2, 4, 9 };
int target = 9;
int result = BinarySearch(arr, target);

if (result != -1)
{
    Console.WriteLine($"Element found at index {result}");
}
else
{
    Console.WriteLine("Element not found in the array");
}