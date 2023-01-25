namespace zad08
{
    internal class Program
    {
        static int CountPrimes(int[] mn)
        {
            int count = 0;
            for(int i = mn[0]; i <= mn[1]; i++) //sprawdzenie czy liczby z przedziału m - n są pierwsze
            {
                int loopNr = 2;
                for (int j = 2; j < i; j++) //sprawdzenie dla liczby i
                {
                    if (i % j == 0) break;  //jeśli liczba i dzielona bez reszty przez j to zatrzymanie sprawdzania
                    loopNr++;
                }
                if(loopNr == i) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            int[] primes = new int[tc];
            for (int i = 0; i < tc; i++)
            {
                string[] strMN = Console.ReadLine().Split(" ").ToArray();
                int[] mn = Array.ConvertAll(strMN, s => int.Parse(s));
                try
                {
                    primes[i] = CountPrimes(mn);
                }
                catch
                {
                    primes[i] = 0; 
                }
            }
            foreach (int numPrimes in primes)
            {
                Console.WriteLine(numPrimes);
            }
        }
    }
}