namespace QuizGame.Models;

public class Question
{
    public string QuestionText { get; set; }
    public string CorrectAnswer { get; set; }
    public IEnumerable<string> IncorrectAnswers { get; set; }
}
