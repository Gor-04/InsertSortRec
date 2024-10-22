class Program
{
    static void InsertionSortRecursive(int[] arr, int n)
    {

        if (n <= 1) return;
        InsertionSortRecursive(arr, n - 1);
        int key = arr[n - 1];
        int j = n - 2;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }

    static void PrintArray(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements:\n");
        string input = Console.ReadLine();

        int n = Convert.ToInt32(input);

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:\n");
        for (int i = 0; i < n; i++)
        {

            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        InsertionSortRecursive(arr, n);

        Console.WriteLine("Sorted Array by Recursive Insertion Sort:\n");
        PrintArray(arr, n);
    }
}