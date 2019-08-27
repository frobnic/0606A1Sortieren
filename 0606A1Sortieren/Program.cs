using System;

namespace _0606A1Sortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean swap = false;
            Random zuf = new Random();
            int[] unsorted = new int[zuf.Next(5,20)];
            int t;

            for (int i = 0; i < unsorted.Length; i++)
                unsorted[i] = zuf.Next(0, 100);

            do
            {
                swap = false;
                for (int i = 1; i < unsorted.Length; i++)
                    if (unsorted[i - 1] > unsorted[i])
                    {
                        t = unsorted[i - 1];
                        unsorted[i - 1] = unsorted[i];
                        unsorted[i] = t;
                        swap = true;
                    }
                foreach (int a in unsorted)
                    Console.Write("{0} ", a);
                Console.WriteLine();
            } while (swap);
        }
    }
}
