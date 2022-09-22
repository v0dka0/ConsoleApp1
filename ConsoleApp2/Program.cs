using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int[] a = new int[20];
            int minchet = 0;
            int minnechet = 0;
            Random rand = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(0, 25);
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            minchet = a[0];
            minnechet = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 2 == 0 && a[i] < minchet && a[i] != 0)
                    minchet = a[i];
                if (a[i] % 2 != 0 && a[i] < minnechet && a[i] != 0)
                    minnechet = a[i];
            }
            Console.WriteLine(minchet);
            Console.WriteLine(minnechet);
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 2 != 0 && a[i] != 0)
                    for (i = 0; i < a.Length; i++)
                    {
                        a[i] = a[i] - minnechet;
                    }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 2 == 0 && a[i] != 0)
                    for (i = 0; i < a.Length; i++)
                    {
                        a[i] = a[i] - minchet;
                    }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
