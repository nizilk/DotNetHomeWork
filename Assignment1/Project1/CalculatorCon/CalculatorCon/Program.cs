namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            double num1=0, num2=0, ans=0;
            string s, cmd;

            while (true)
            {
                Console.WriteLine("四则运算！\n");
                Console.WriteLine("Please input 2 numbers: ");
                s = Console.ReadLine();
                flag = flag && Double.TryParse(s, out num1);
                s = Console.ReadLine();
                flag = flag && Double.TryParse(s, out num2);
                Console.Write($"{Environment.NewLine}Pleaase input an operator: ");
                string op = Console.ReadLine();
                if (flag) { ans = Cal(num1, num2, op, ref flag); }

                if (flag)
                {
                    Console.WriteLine($"{Environment.NewLine}{num1} {op} {num2} = {ans}.");
                }
                else
                {
                    Console.WriteLine($"{Environment.NewLine}error! ");
                }
                Console.WriteLine($"{Environment.NewLine}Input 'exit' to quit, or press any key to continue...");
                cmd = Console.ReadLine();
                if(cmd == "exit") { break; }
                Console.Clear();
            }
            Console.Write($"{Environment.NewLine}Calculation end. Press any key to exit...");
            Console.ReadKey(true);
        }

        static double Cal(double x, double y, string op, ref bool flag)
        {
            switch (op)
            {
                case "+":   return x + y; 
                case "-":   return x - y;
                case "*":   return x * y;
                case "/":   return x / y;
                default :   flag = false;    return double.NaN;
            }
        }
    }
}