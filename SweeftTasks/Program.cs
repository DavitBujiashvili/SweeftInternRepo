namespace SweeftTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array ={
                                "civic",
                                "deified",
                                "deleveled",
                                "devoved",
                                "dewed",
                                "Hannah",
                                "kayak",
                                "level",
                                "madam",
                                "racecar",
                                "radar",
                                "redder",
                                "refer",
                                "repaper",
                                "reviver",
                                "rotator",
                                "rotor",
                                "sagas",
                                "solos",
                                "sexes",
                                "stats",
                                "tenet",
                                "Dot",
                                "Net",
                                "Perls",
                                "Is",
                                "Not",
                                "A",
                                "Palindrome",
                                ""
                                };

            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
        }

        public static bool IsPalindrome(string text)
        {
            string first = text.Substring(0, text.Length / 2);
            char[] arr = text.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}