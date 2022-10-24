namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            static string GetLastHalf(string text)
            {
                int len = text.Length / 2;
                string half = text.Remove(0, len);
                string result = half.Replace(" ", "");
                return result;
            }

            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
    }
}