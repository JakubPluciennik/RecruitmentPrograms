namespace zad07
{
    internal class Program
    {
        static void Decomposition(uint number, SortedSet<uint> set)
        {
            uint pow2 = 1;
            while(number > 0)
            {
                uint w = number & 1;    //bit na miejscu 1
                if(w == 1)
                {
                    set.Add(pow2);  //dodanie potęgi dwójki do zbioru
                }
                number>>= 1;    //przesunięcie o 1 bit - podzielenie przez 2
                pow2 <<= 1; //podwojenie potęgi 2
            }
        }
        static void Main(string[] args)
        {
            SortedSet<uint> set = new SortedSet<uint>();
            List<uint> list = new List<uint>();
            while (true)
            {
               string s = Console.ReadLine();

                if(s == null)
                {
                    break;
                }
                try
                {
                    list.Add(uint.Parse(s));
                }
                catch { break; }
            }
            foreach (uint i in list) { Decomposition(i, set); }
            string wynik = "";
            if (set.Count == 0) wynik = "NA";
            else
            {
                uint[] arr = set.ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1)
                    {
                        wynik += arr[i] + ", ";
                    }
                    else { wynik += arr[i]; }
                }
            }
            Console.WriteLine(wynik);
        }
    }
}