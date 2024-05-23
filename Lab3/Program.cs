namespace Lab3
    {

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it is a palindrome:");
            string eye = Console.ReadLine();


            if (TestPalindrome(eye))
            {
                Console.WriteLine($"{eye} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{eye} is not a palindrome.");
            }

            static bool TestPalindrome(string palindrome)
            {
                bool IsPalindrome = false;
                for (int i = 0; i < palindrome.Length / 2; i++)
                {
                    if (!(palindrome[i] == palindrome[palindrome.Length - i - 1]))
                    {
                        return false;
                    }


                }
                return true;
            }
        }
    }
}
