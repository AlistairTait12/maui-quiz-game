using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

    [RelayCommand]
    public void SubmitAnswer()
    {
        // TODO Will likely need to refactor this to adhere to SRP

        // TODO Check answer

        // TODO Update result

        // TODO Check if there are any more questions left in the list

        // TODO Make this actually move on somehow
        var currentIndex = Questions.ToList().IndexOf(currentQuestion);
        CurrentQuestion = Questions.ElementAt(currentIndex + 1);
    }

    [ObservableProperty]
    Question currentQuestion;
}
