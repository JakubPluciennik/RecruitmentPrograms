namespace zad06
{
    internal class Program
    {
        static string IsPermutation(int[] a, int[] b)
        {
            int maxA = a.Max();
            int maxB = b.Max();
            if (maxA != maxB)
            {
                // jeśli tablice mają inną wartość maksymalną to nie są permutacjami
                return "NO";
            }

            int[] permA = new int[maxA + 1];
            int[] permB = new int[maxB + 1];

            for (int i = 0; i < a.Length; i++)
            {
                //w tablicy permA, permB zliczane wystąpienia liczb na pozycji i
                // np. jeśli w tablicy a występuje liczba 3, to na 3-cim miejscu w tablicy permA dodanie 1
                permA[a[i]] += 1;
                permB[b[i]] += 1;
            }
            if (Enumerable.SequenceEqual(permA, permB)) return "YES";
            else return "NO";
        }

        static void Main(string[] args)
        {
            string[] stringA = Console.ReadLine().Split(" ");
            string[] stringB = Console.ReadLine().Split(" ");
            string wynik = "NO";
            try
            {
                int[] a = Array.ConvertAll(stringA, s => int.Parse(s));
                int[] b = Array.ConvertAll(stringB, s => int.Parse(s));

                wynik = IsPermutation(a, b);
            }
            catch { wynik = "NO"; }
            finally { Console.WriteLine(wynik); }

        }
    }
}