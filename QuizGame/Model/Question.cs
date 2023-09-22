using CommunityToolkit.Mvvm.ComponentModel;

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

        // TODO Shuffle the answers at this point

        return answers;
    }
}
