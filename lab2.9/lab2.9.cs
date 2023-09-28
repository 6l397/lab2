class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        Console.WriteLine("Enter a lowercase word:");
        string word = Console.ReadLine();

        foreach (char letter in word)
        {
            if (Char.IsLower(letter))
            {
                int index = Array.IndexOf(alphabet, letter);
                Console.WriteLine($"{letter} -> {index}");
            }
            else
            {
                Console.WriteLine($"{letter} is not a lowercase letter.");
            }
        }
    }
}
