using System;
using System.Collections.Generic;
using System.Linq;

namespace RangeTrade
{
    class Program
    {

        private static Dictionary<string, Tuple<double, double>> stocksAndBounds = new Dictionary<string, Tuple<double, double>>();


        private static void Main(string[] args)
        {

            stocksAndBounds.Add("Apple", new Tuple<double, double>(100, 150));
            stocksAndBounds.Add("Microsoft", new Tuple<double, double>(80, 120));
            stocksAndBounds.Add("Tesla", new Tuple<double, double>(250, 350));

            Random rand = new Random();
            Random rand2 = new Random();

            for (int i = 0; i < 20; i++)
            {

                string value = stocksAndBounds.ElementAt(rand.Next(0, stocksAndBounds.Count)).Key;
                Tuple<double, double> bounds = stocksAndBounds[value];

                Console.WriteLine($"============{value}============\n");

                int number = rand2.Next(50, 400);

                Console.WriteLine($"Current Value: {number}");
                Console.WriteLine();

                double lowerBound = bounds.Item1;
                double upperBound = bounds.Item2;

                //double.TryParse(args[0], out double number);

                //double.TryParse(args[1], out double lowerBound);

                //double.TryParse(args[2], out double upperBound);

                if (number >= lowerBound && number < upperBound)
                {
                    Console.WriteLine("buy");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("do not buy");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private IEnumerable<TValue> RandomValues<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            Random rand = new Random();
            List<TValue> values = Enumerable.ToList(dict.Values);
            int size = dict.Count;
            while (true)
            {
                yield return values[rand.Next(size)];
            }
        }
    }
}
