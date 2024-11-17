using System.Text.Json.Serialization;

class Question
{
    [JsonPropertyName("question")]
    public string QuestionText { get; set; }

    [JsonPropertyName("correct_answer")]
    public string CorrectAnswer { get; set; }
}