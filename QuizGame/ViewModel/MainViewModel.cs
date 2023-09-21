using CommunityToolkit.Mvvm.Input;
using QuizGame.View;

namespace QuizGame.ViewModel;

public partial class MainViewModel
{
    public MainViewModel()
    {
    }

    [RelayCommand]
    public async Task GoToAboutPageAsync()
    {
        await Shell.Current.GoToAsync(nameof(AboutPage));
    }
}
