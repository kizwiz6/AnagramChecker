namespace AnagramChecker
{
    internal class Program
    {
        public static bool AreAnagrams(string str1, string str2)
        {
            // Convert strings to character arrays
            char[] charArray1 = str1.ToLower().ToCharArray();
            char[] charArray2 = str2.ToLower().ToCharArray();

            // Sort character arrays
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // Compare sorted arrays
            return charArray1.SequenceEqual(charArray2);

        }



        static void Main(string[] args)
        {
            Console.Write("Word 1:");
            string word1 = Console.ReadLine();
            Console.Write("Word 2:");
            string word2 = Console.ReadLine();

            if (AreAnagrams(word1, word2))
            {
                Console.WriteLine($"{word1} and {word2} are anagrams.");
            }
            else
            {
                Console.WriteLine($"{word1} and {word2} are NOT anagrams.");
            }
        }
    }
}
