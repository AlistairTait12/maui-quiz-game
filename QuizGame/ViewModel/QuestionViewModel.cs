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
        // TODO Make this actually move on somehow
        CurrentQuestion = Questions.ElementAt(1);
    }

    [RelayCommand]
    public void SayHi()
    {
        Shell.Current.DisplayAlert("Yo", "Yo there, you discovered the button", "Thanks");
    }

    [ObservableProperty]
    Question currentQuestion;
}
