class MaxSequenceOfEqualElements
{
    static void Main()
    {
        Console.WriteLine("Enter the elements of the array:");
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');

        int bestStart = 0;
        int bestLen = 1;

        int currentStart = 0;
        int currentLen = 1;

        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] == elements[i - 1])
            {
                currentLen++;

                if (currentLen > bestLen)
                {
                    bestLen = currentLen;
                    bestStart = currentStart;
                }
            }
            else
            {
                currentStart = i;
                currentLen = 1;
            }
        }

        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(elements[i] + " ");
        }
    }
}
