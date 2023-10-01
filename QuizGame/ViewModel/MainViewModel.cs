using CommunityToolkit.Mvvm.Input;
using QuizGame.View;

namespace QuizGame.ViewModel;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
    }

    [RelayCommand]
    public async Task GoToFirstQuestionAsync()
    {
        await Shell.Current.GoToAsync(nameof(QuestionPage));
    }
}
