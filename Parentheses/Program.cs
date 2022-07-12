namespace Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან.დაწერეთ
            //ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად
            //სწორად დასმული.

            Console.WriteLine(IsProperly("((()))"));
        }

        static bool IsProperly(string sequence)
        {
            if (string.IsNullOrEmpty(sequence))
                return true;

            Stack<char> brackets = new Stack<char>();

            foreach (var c in sequence)
            {
                if (c == '(')
                    brackets.Push(c);
                else if (c == ')')
                {
                    if (brackets.Count <= 0)
                        return false;

                    brackets.Pop();
                }
            }

            if (brackets.Count > 0)
                return false;

            return true;
        }
    }
}