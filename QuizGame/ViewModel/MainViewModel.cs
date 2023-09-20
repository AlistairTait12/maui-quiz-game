using CommunityToolkit.Mvvm.Input;

namespace QuizGame.ViewModel;

public partial class MainViewModel
{
    public MainViewModel()
    {
    }

    [RelayCommand]
    public async Task GoToAboutPageAsync()
    {
        // TODO: Make this navigate to the about page
        Console.WriteLine("We hit the breakpoint yeah boi");
        await Task.Delay(TimeSpan.FromSeconds(1));
    }
}
