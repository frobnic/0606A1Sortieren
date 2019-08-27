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
            /*
                        int[] unsorted = new int[zuf.Next(5,20)];

                        for (int i = 0; i < unsorted.Length; i++)
                            unsorted[i] = zuf.Next(0, 100);
            */
            int[] unsorted = new int[] { 5, 1, 4, 2, 8 };

            Console.WriteLine("Unsortiert:");
            foreach (int a in unsorted)
                Console.Write("{0} ", a);
            Console.WriteLine();
            Console.WriteLine("Und nun sortieren wir:");

            while (swap)
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
                if (swap)
                    foreach (int a in unsorted)
                        Console.Write("{0} ", a);
                Console.WriteLine();
            }
        }
    }
}
