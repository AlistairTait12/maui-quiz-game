namespace QuizGame.Model;

public class Question
{
    public string QuestionText { get; set; }
    public string CorrectAnswer { get; set; }
    public IEnumerable<string> IncorrectAnswers { get; set; }
    public IEnumerable<string> AllAnswers => GetAllAnswers();
    private IEnumerable<string> GetAllAnswers()
    {
        var answers = new List<string>
        {
            CorrectAnswer
        };

        answers.AddRange(IncorrectAnswers);

        return ShuffleAnswers(answers);
    }

    private IEnumerable<string> ShuffleAnswers(IEnumerable<string> unShuffledAnswers)
    {
        var answers = unShuffledAnswers.ToArray();
        var rand = new Random();
        for (int i = answers.Length - 1; i > 0; i--)
        {
            var k = rand.Next(i + 1);
            var val = answers[k];
            answers[k] = answers[i];
            answers[i] = val;
        }

        return answers;
    }
}
