using System;

namespace Program
{
    internal abstract class Operations
    {
        public static double Entropy(string[] probabilities)
        {
            double entropy = 0;

            for (int i = 0; i < probabilities.Length; i++)
            {
                double probability = double.Parse(probabilities[i]);
                entropy += -probability * Math.Log(probability, 2);
            }

            Console.WriteLine($"Ентопія: {entropy}");
            return entropy;
        }

        public static double AverageCharLength(string[] probabilities, string[] time)
        {
            double averageCharLength = 0;

            for (int i = 0; i < time.Length; i++)
            {
                double probability = double.Parse(probabilities[i]);
                double duration = double.Parse(time[i]);

                averageCharLength += probability * duration;
            }
            
            Console.WriteLine($"Середнє значення тривалості символу: {averageCharLength}");
            return averageCharLength;
        }

        public static void Productivity(double entropy, double averageCharLength)
        {
            double productivity = entropy / averageCharLength;
            Console.WriteLine($"\nПродуктивність джерела: {productivity}");
        }

        public static void Redundancy(double entropy, int timeLength)
        {
            double redundancy = 1 - entropy / Math.Log(timeLength, 2);
            Console.WriteLine($"\nНадмірність джерела: {redundancy}");
        }
    }
}