using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class QuizManager
{
    private readonly ApiClient _apiClient;
    private readonly ScoreManager _scoreManager;
    private List<Question> _questions;

    public QuizManager()
    {
        _apiClient = new ApiClient();
        _scoreManager = new ScoreManager();
    }

    public async Task StartQuiz()
    {
        _questions = await _apiClient.FetchQuestions(5);
        int currentQuestion = 0;

        foreach (var question in _questions)
        {
            currentQuestion++;
            ConsoleAnimator.DrawQuestion(question, currentQuestion, _questions.Count);

            var userAnswer = Console.ReadLine().Trim().ToLower();
            bool isCorrect = userAnswer == question.CorrectAnswer.ToLower();

            ConsoleAnimator.DrawAnswerResult(isCorrect, question.CorrectAnswer);
            _scoreManager.UpdateScore(isCorrect);

            await Task.Delay(2000);
        }

        ConsoleAnimator.DrawFinalScore(_scoreManager.GetScore(), _questions.Count);
    }
}