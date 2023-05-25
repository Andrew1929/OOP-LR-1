using System;

namespace OOP_LR_1._3
{
    delegate float Avg(int x, int y, int z);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int z = Convert.ToInt32(Console.ReadLine());
            Avg avg = Average;
            float Average(int x, int y, int z) => (x + y + z) / 3;
            float result = avg(x, y, z);
            Console.WriteLine("-----------");
            Console.WriteLine(result);
        }
    }
}
