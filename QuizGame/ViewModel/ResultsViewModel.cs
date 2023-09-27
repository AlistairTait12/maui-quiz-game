using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizGame.Model;
using QuizGame.View;

namespace QuizGame.ViewModel;

[QueryProperty(nameof(Result), "ResultsModel")]
public partial class ResultsViewModel : BaseViewModel
{
    public ResultsViewModel()
    {
    }

    [ObservableProperty]
    ResultsModel result;

    [RelayCommand]
    public async Task GoHomeAsync()
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}
