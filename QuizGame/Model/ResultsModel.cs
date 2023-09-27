namespace QuizGame.Model;

public class ResultsModel
{
    public ResultsModel()
    {
    }

    public int UserScore { get; set; }

    public int TotalQuestions { get; set; }

    public string Message => $"Final score: {UserScore} out of {TotalQuestions}";
}
