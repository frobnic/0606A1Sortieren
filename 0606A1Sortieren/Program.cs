using System;

namespace _0606A1Sortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean swap = false;
            int[] unsorted = new int[] { 5, 2, 6, 4, 8, 3, 8, 7, 2, 4, 5 };
            int t;

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
