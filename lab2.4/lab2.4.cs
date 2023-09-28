class SieveOfEratosthenes
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new bool[n + 1];

        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        primes[0] = primes[1] = false;

        for (int p = 2; p <= n; p++)
        {
            if (primes[p])
            {
                Console.Write(p + " ");
                
                for (int i = 2 * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }

        Console.WriteLine();
    }
}
