using System.Data.SqlTypes;

namespace EraSieve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ans = Era(100);
            foreach (int i in ans)
            {
                Console.Write($"{i}  ");
            }
            Console.Write($"\n\nPress any key to exit...");
            Console.ReadKey(true);
        }

        static int[] Era(int num)
        {
            int[] a = new int[num + 1];     //下标代表数，对应值为0则是素数，为1则不是素数
            a[0] = a[1] = 1;
            int count = num - 1, k=0, i;
            int it = (int)Math.Sqrt(num);
            for (i=2; i<=it; i++)
            {
                if (a[i] == 1)
                {
                    continue;
                }
                for(int j=i*i; j<=num; j += i)
                {
                    if (a[j] == 1) { continue; }
                    a[j] = 1;
                    count--;
                }
            }
            int[] res = new int[count];
            for (i=0; i<=num; i++)
            {
                if (a[i] == 0)
                {
                    res[k] = i;
                    k++;
                }
            }
            return res;
        }
    }
}