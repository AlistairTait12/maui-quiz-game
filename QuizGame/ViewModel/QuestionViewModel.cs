using CommunityToolkit.Mvvm.ComponentModel;
using QuizGame.Model;
using QuizGame.Service;

namespace QuizGame.ViewModel;

public partial class QuestionViewModel : BaseViewModel
{
    public IEnumerable<Question> Questions { get; set; }

    public QuestionViewModel(IQuestionService questionService)
    {
        Questions = questionService.GetQuestions();
        currentQuestion = Questions.FirstOrDefault();
    }

    [ObservableProperty]
    Question currentQuestion;
}
