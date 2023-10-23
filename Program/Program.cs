using System;

namespace Program
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Обчислюємо ентропії:\nВведіть чисельні значення ймовірностей через пробіл:");
            string[] probabilities = Console.ReadLine().Split();
            double entropy = Operations.Entropy(probabilities);

            Console.WriteLine("\nОбчислюємо середню тривалість символу:\nВведіть тривалість через пробіл:");
            string[] time = Console.ReadLine().Split();
            double averageCharLength = Operations.AverageCharLength(probabilities, time);

            Operations.Productivity(entropy, averageCharLength);
            Operations.Redundancy(entropy, time.Length);
        }
    }
}