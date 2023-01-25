namespace zad11
{
    internal class Program
    {
        private static int CountDigits(string[] text)
        {
            int[] digits = new int[10]; //tablica cyfr 0-10

            foreach (string s in text)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    byte index = byte.Parse(s[i].ToString());
                    digits[index] += 1;
                }
            }
            int max = digits[0];
            int wynik = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] >= max)
                {
                    max = digits[i];
                    wynik = i;
                }
            }
            return wynik;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[] text = Console.ReadLine().Split(" ").ToArray();
            Console.WriteLine(CountDigits(text));
        }
    }
}