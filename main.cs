using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.CursorVisible = false;
        ConsoleAnimator.InitializeConsole();

        while (true)
        {
            ConsoleAnimator.DrawMainMenu();
            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.Enter:
                    await PlayQuiz();
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static async Task PlayQuiz()
    {
        var quizManager = new QuizManager();
        await quizManager.StartQuiz();

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey(true);
    }
}