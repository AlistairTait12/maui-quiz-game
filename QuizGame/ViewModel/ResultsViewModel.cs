using CommunityToolkit.Mvvm.Input;
using QuizGame.View;

namespace QuizGame.ViewModel;

public partial class ResultsViewModel : BaseViewModel
{
    [RelayCommand]
    public async Task GoHomeAsync()
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}
