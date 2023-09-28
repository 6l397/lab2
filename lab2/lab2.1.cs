class LargestCommonEnd
{
    static void Main()
    {
        Console.WriteLine("Enter the first array of words:");
        string[] array1 = Console.ReadLine().Split(' ');
        Console.WriteLine("Enter the second array of words:");
        string[] array2 = Console.ReadLine().Split(' ');

        int leftCommonLength = FindCommonEndLength(array1, array2);

        Array.Reverse(array1);
        Array.Reverse(array2);

        int rightCommonLength = FindCommonEndLength(array1, array2);

        if (leftCommonLength >= rightCommonLength)
        {
            Console.WriteLine(leftCommonLength);
        }
        else
        {
            Array.Reverse(array1);
            Console.WriteLine(rightCommonLength);
        }
    }

    static int FindCommonEndLength(string[] arr1, string[] arr2)
    {
        int minLength = Math.Min(arr1.Length, arr2.Length);
        int commonLength = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] == arr2[i])
            {
                commonLength++;
            }
            else
            {
                break;
            }
        }

        return commonLength;
    }
}
