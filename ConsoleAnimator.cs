using System;
using System.Threading;

static class ConsoleAnimator
{
    public static void InitializeConsole()
    {
        Console.WindowHeight = 30;
        Console.WindowWidth = 80;
        Console.Title = "Quiz Game by JohnDev19";
    }

    public static void DrawMainMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ColorPalette.Primary;
        Console.WriteLine(@"
░██████╗░██╗░░░██╗██╗███████╗
██╔═══██╗██║░░░██║██║╚════██║
██║██╗██║██║░░░██║██║░░███╔═╝
╚██████╔╝██║░░░██║██║██╔══╝░░
░╚═██╔═╝░╚██████╔╝██║███████╗
░░░╚═╝░░░░╚═════╝░╚═╝╚══════╝
        ");
        Console.ResetColor();
        Console.WriteLine("\n\n             Press ENTER to start or Q to quit");

        AnimateText("Get ready for an exciting quiz experience!", 15, 2);
    }

    public static void DrawQuestion(Question question, int current, int total)
    {
        Console.Clear();
        Console.ForegroundColor = ColorPalette.Secondary;
        Console.WriteLine($"Question {current}/{total}");
        Console.ResetColor();
        Console.WriteLine("\n" + question.QuestionText);
        Console.WriteLine("\nTrue or False?");
    }

    public static void DrawAnswerResult(bool isCorrect, string correctAnswer)
    {
        Console.ForegroundColor = isCorrect ? ColorPalette.Correct : ColorPalette.Incorrect;
        Console.WriteLine(isCorrect ? "\nCorrect!" : $"\nIncorrect. The correct answer was: {correctAnswer}");
        Console.ResetColor();
    }

    public static void DrawFinalScore(int score, int total)
    {
        Console.Clear();
        Console.ForegroundColor = ColorPalette.Primary;
        Console.WriteLine("Final Score:");
        Console.ResetColor();
        Console.WriteLine($"\n{score} out of {total} correct!");

        AnimateText("Thanks for playing!", 20, 2);
    }

    private static void AnimateText(string text, int left, int top)
    {
        Console.SetCursorPosition(left, top);
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
    }
}