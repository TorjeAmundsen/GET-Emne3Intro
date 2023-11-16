using TestSpace;

namespace Emne3Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = MyConsole.Ask("Input a number: ");
            try
            {
                int number = int.Parse(input);
                bool isNumberEven = isEven(number);
                string even = "even!";
                string odd = "odd!";
                Console.WriteLine($"The number \"{input}\" is {(isNumberEven ? even : odd)}");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        static bool isEven(int x)
        {
            return x % 2 == 0;
        }
    }
}