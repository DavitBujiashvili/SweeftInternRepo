namespace Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2
            //საფეხურით.დაწერეთ ფუნქცია რომელიც დაითვლის n სართულზე ასვლის
            //ვარიანტების რაოდენობას.
            Console.WriteLine(CountVariants(5));
        }

        public static int CountVariants(int stairCount)
        {
            if (stairCount == 1 || stairCount == 2) return stairCount;
            return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
        }
    }
}