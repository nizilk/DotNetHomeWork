namespace MaxMinAveSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an int array: ");
            string[] data = Console.ReadLine().Split(new string[] { " ", ",", "，", ";", "；" }, StringSplitOptions.RemoveEmptyEntries);
            bool flag = isAllInt(data);
            if(flag)
            {
                int[] a = Array.ConvertAll(data, int.Parse);
                Console.WriteLine($"{Environment.NewLine}Max number: {a.Max()}");
                Console.WriteLine($"{Environment.NewLine}Min number: {a.Min()}");
                Console.WriteLine($"{Environment.NewLine}Average: {a.Average()}");
                Console.WriteLine($"{Environment.NewLine}Sum: {a.Sum()}");
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Error! ");
            }
            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }

        static bool isAllInt(string[] data)
        {
            int num;
            foreach (string s in data)
            {
                if(!int.TryParse(s, out num))
                {
                    return false;
                }
            }
            return true;
        }
    }
}