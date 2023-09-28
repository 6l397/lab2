class FoldAndSum
{
            static void Main()
            {
                Console.WriteLine("Enter 4*k integers:");
                string[] input = Console.ReadLine().Split(' ');

                int k = input.Length / 4;

                int[] array = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    array[i] = int.Parse(input[i]);
                }

                int[] foldedArray = new int[2 * k];

                for (int i = 0; i < k; i++)
                {
                    foldedArray[i] = array[k - i - 1] + array[k + i];
                    foldedArray[k + i] = array[3 * k - i - 1] + array[3 * k + i];
                }

                Console.WriteLine("Folded and summed array:");
                Console.WriteLine(string.Join(" ", foldedArray));
            }
        }
