class ScoreManager
{
    private int _score;

    public void UpdateScore(bool isCorrect)
    {
        if (isCorrect)
        {
            _score++;
        }
    }

    public int GetScore()
    {
        return _score;
    }
}