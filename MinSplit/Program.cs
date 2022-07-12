namespace MinSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. დაწერეთ
            //ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს მინიმალურ მთელ
            //რიცხვს, რომელიც 0 - ზე მეტია და ამ მასივში არ შედის.

            var minValue = NotContains(new int[] { -1, 8, 3 });
            Console.WriteLine(minValue);


        }

        static int NotContains(int[] numbers)
        {
            var cache = new HashSet<int>();

            int min = FindMinValue(numbers, cache);
            min = min < 0 ? 0 : min;

            while (true)
            {
                min++;

                if (!Contains(min, cache))
                {
                    return min;
                }
            }
        }

        public static bool Contains(int value, HashSet<int> collection)
        {
            return collection.Contains(value);
        }
        public static int FindMinValue(int[] array, HashSet<int> collection)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty");
            }

            int min = int.MaxValue;
            foreach (var i in array)
            {
                collection.Add(i);

                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}