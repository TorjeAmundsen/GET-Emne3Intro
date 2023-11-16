namespace TestSpace
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.Write(question);
            var name = Console.ReadLine();
            return name;
        }
    }
}