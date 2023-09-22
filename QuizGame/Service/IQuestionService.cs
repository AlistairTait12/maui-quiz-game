using QuizGame.Model;

namespace QuizGame.Service;

public interface IQuestionService
{
    IEnumerable<Question> GetQuestions();
}
