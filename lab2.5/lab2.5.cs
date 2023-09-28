class CompareCharArrays
{
    static void Main() {
        Console.WriteLine("Enter the first char array: ");
        char[] arr1 = Console.ReadLine().ToCharArray();
        Console.WriteLine("Enter the second char array: ");
        char[] arr2 = Console.ReadLine().ToCharArray();
        int minLength = Math.Min(arr1.Length, arr2.Length);
        bool equal = true;
        string str1 = new string(arr1);
        string str2 = new string(arr2);
        for (int i = 0; i < minLength; i++) {
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine(str1);
                Console.WriteLine(str2);
                equal = false;
                break;
            }
            else if (arr1[i] > arr2[i]) { 
            Console.WriteLine(str2);
            Console.WriteLine(str1);
            equal = false;
            break;
            }
        }
        if (equal && arr1.Length != arr2.Length) { 
            Console.WriteLine(arr1.Length < arr2.Length ? str1 : str2);
            Console.WriteLine(arr1.Length < arr2.Length ? str2 : str1) ;
        }
        else if (equal)
        {
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}