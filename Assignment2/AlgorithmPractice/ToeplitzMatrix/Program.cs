using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToeplitzMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            string[] row;
            Console.WriteLine("Please input the size of matrix: ");
            Console.Write("M = ");
            int.TryParse(Console.ReadLine(), out m);
            Console.Write("N = ");
            int.TryParse(Console.ReadLine(), out n);
            double[,] matrix = new double[m, n];
            Console.WriteLine("\nPlease input a matrix: ");
            for(int i=0; i<m; i++)
            {
                row = Console.ReadLine().Split(new string[] { " ", ",", "，", ";", "；" }, StringSplitOptions.RemoveEmptyEntries);
                for (int j=0; j<n; j++)
                {
                    matrix[i, j] = Double.Parse(row[j]);
                }
            }
            bool ans = IsTMatrix(matrix);
            Console.WriteLine($"\n{ans}");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }

        static bool IsTMatrix(double[,] a)
        {
            for(int i=1; i<a.GetLength(0); i++)
            {
                for(int j=1; j<a.GetLength(1); j++)
                {
                    if (a[i,j] != a[i-1,j-1]) return false;
                }
            }
            return true;
        }
    }
}