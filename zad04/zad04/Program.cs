namespace zad04
{
    internal class Program
    {
        static string WriteReverse(string[] s)
        {
            string wynik = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                wynik += s[i] + " ";
            }
            return wynik;
        }

        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');

            if (size == s.Length)
            {
                Console.WriteLine(WriteReverse(s));
            }

        }
    }
}