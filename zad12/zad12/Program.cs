namespace zad12
{
    internal class Program
    {
        static int DigitSumIndex(string[] text)
        {
            int[] sum = new int[text.Length];

            for (int j = 0; j < text.Length; j++)
            {
                int sumD = 0;
                for (int i = 0; i < text[j].Length; i++)  //dodawanie wszystkich cyfr w liczbie
                {
                    sumD += int.Parse(text[j][i].ToString());
                }
                sum[j] = sumD;
            }
            int max = sum[0];
            int wynik = 0;
            for (int i = 0; i < sum.Length; i++)
            {
                if (sum[i]>= max)
                {
                    max = sum[i];
                    wynik = i;
                }
            }
            return wynik;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] text = Console.ReadLine().Split(" ").ToArray();
            Console.WriteLine(DigitSumIndex(text));
        }
    }
}