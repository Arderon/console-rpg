namespace ConsoleRPG
{
    class Program()
    {
        static void Main()
        {
            Console.WriteLine("Welcome to ConsoleRPG!");
            GameManager gm = new GameManager();
            gm.StartGame();
        }
    }
}