class MostFrequentNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');

        int mostFrequentNumber = 0;
        int maxFrequency = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            int currentNumber = int.Parse(elements[i]);
            int currentFrequency = 1;

            for (int j = i + 1; j < elements.Length; j++)
            {
                if (int.Parse(elements[j]) == currentNumber)
                {
                    currentFrequency++;
                }
            }

            if (currentFrequency > maxFrequency)
            {
                mostFrequentNumber = currentNumber;
                maxFrequency = currentFrequency;
            }
        }

        Console.WriteLine(mostFrequentNumber);
    }
}
