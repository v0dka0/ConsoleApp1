using System;
using System.Linq;

namespace ConsoleApp1
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            int[] ar = new int[10];
            Random rand = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.Next(1000);
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int minchet = ar[0];
            int minnechet = ar[0];
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] % 2 == 0 && ar[i] < minchet && ar[i] != 0)
                    minchet = ar[i];
                if (ar[i] % 2 != 0 && ar[i] < minnechet && ar[i] != 0)
                    minnechet = ar[i];
            }
            Console.WriteLine(minchet);
            Console.WriteLine(minnechet);
            Console.WriteLine();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 > 0 && ar[i] > minnechet && ar[i] != 0)
                        ar[i] = ar[i] - minnechet;
            }
            
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0 && ar[i] > minchet && ar[i] != 0)
                        ar[i] = ar[i] - minchet;
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
        }
    }
}
