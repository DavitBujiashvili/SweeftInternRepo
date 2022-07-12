namespace Cents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც
            //გადაეცემა თანხა(თეთრებში) და აბრუნებს მონეტების მინიმალურ
            //რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.

            Console.WriteLine(MinSplit(50));

        }

        static int MinSplit(int amount)
        {
            int[] coins = {50, 20, 10, 5, 1 };
            int count = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                count += amount / coins[i];
                amount %= coins[i];
            }
            return count;
        }
    }
}