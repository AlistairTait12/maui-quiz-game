using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizGame.Model;
using QuizGame.Service;
using QuizGame.View;

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
    public async Task SubmitAnswer()
    {
        // TODO Will likely need to refactor this to adhere to SRP

        // TODO Check answer

        // TODO Update result

        // TODO Check if there are any more questions left in the list
        if (currentQuestion == Questions.Last())
        {
            await Shell.Current.GoToAsync(nameof(ResultsPage));
        }
        else
        {
            var currentIndex = Questions.ToList().IndexOf(currentQuestion);
            CurrentQuestion = Questions.ElementAt(currentIndex + 1);
        }
    }

    [ObservableProperty]
    Question currentQuestion;
}
