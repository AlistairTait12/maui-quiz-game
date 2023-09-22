using QuizGame.Model;

namespace QuizGame.Service;

public class FakeQuestionService : IQuestionService
{
    public IEnumerable<Question> GetQuestions()
    {
        return new List<Question>()
        {
            new ()
            {
                QuestionText = "Which one played bass?",
                CorrectAnswer = "Paul",
                IncorrectAnswers = new [] { "John", "George", "Ringo" }
            },
            new()
            {
                QuestionText = "What is the meaning of life?",
                CorrectAnswer = "42",
                IncorrectAnswers = new [] { "Cake", "24" }
            }
        };
    }
}
