namespace zad05
{
    internal class Program
    {
        static string IsPalindrome(string s)
        {
            string str = new string(s.Where(c => char.IsLetter(c)).ToArray());
            bool palindrome = true;
            for(int i=0; i<str.Length/2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    palindrome = false;
                    break;
                }
            }

            if (palindrome) return "YES";
            else return "NO";
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            Console.WriteLine(IsPalindrome(s));
        }
    }
}