using System;

namespace OOP_LR_1._2
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate[] delegates = new RandomNumberDelegate[5];
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => new Random().Next(100);
            }
            double average = CalculateAverage(delegates);
            Console.WriteLine("Середнє арифметичне: " + average);
        }
        static double CalculateAverage(RandomNumberDelegate[] delegates)
        {
            int sum = 0;
            foreach (RandomNumberDelegate del in delegates)
            {
                sum += del();
            }
            double average = (double)sum / delegates.Length;
            return average;
        }
    }
}