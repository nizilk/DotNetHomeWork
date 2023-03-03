using System.Collections;

namespace PrimeFactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool flag;
            Console.Write("Please input an int number: ");
            flag = Int32.TryParse(Console.ReadLine(), out num);
            Console.WriteLine();

            if (flag)
            {
                ArrayList ans = PrimeFac(num);
                if(ans.Count == 0)
                {
                    Console.Write("None! ");
                }
                foreach (int i in ans)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                Console.Write("Error! ");
            }
            Console.Write("\n\nPress any to exit...");
            Console.ReadKey(true);
        }

        static ArrayList PrimeFac(int num)
        {
            ArrayList ans = new ArrayList();
            for(int i = 2; i <= num; i++)
            {
                if(num%i != 0)
                {
                    continue;
                }
                if(IsPrime(i))
                {
                    ans.Add(i);
                }
            }
            return ans;
        }

        static bool IsPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}