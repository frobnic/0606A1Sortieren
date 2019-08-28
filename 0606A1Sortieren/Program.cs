using System;

namespace _0606A1Sortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean swap = true;
            Random zuf = new Random();
            int t;
            //   int[] unsorted = new int[zuf.Next(300, 500)];
            int cnt = 0;

            //    for (int i = 0; i < unsorted.Length; i++)
            //        unsorted[i] = zuf.Next(1, unsorted.Length);
            // int[] unsorted = new int[] { 5, 1, 4, 2, 8 };
            int[] unsorted = new int[] { 8, 7, 6, 5, 4 };

            Console.WriteLine("Unsortiert:");
            foreach (int a in unsorted)
                Console.Write("{0} ", a);
            Console.WriteLine();
            Console.WriteLine("Und nun sortieren wir:");

            int end = unsorted.Length;

            while (swap)
            {
                swap = false;
                for (int i = 1; i < end; i++)
                {
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
                }
                Console.WriteLine();
                cnt++;
                end--;
            }
            Console.WriteLine("{0} Durchläufe wurden benötigt fuer ein Feld mit {1} Elementen", cnt, unsorted.Length);
            Console.WriteLine();
        }
    }
}
