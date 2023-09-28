class Program
{
    static void Main()
    {
        Console.WriteLine("Enter integers separated by spaces:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        Console.WriteLine("Enter the number of rotations (k):");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        int[] sumArray = new int[array.Length];
        int[] rotatedArray = new int[array.Length];

        for (int r = 0; r < k; r++)
        {
           
            int lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement;

            for (int i = 0; i < array.Length; i++)
            {
                sumArray[i] += array[i];
            }

            array.CopyTo(rotatedArray, 0);
        }

        Console.WriteLine("Result: " + string.Join(" ", sumArray));
    }
}
