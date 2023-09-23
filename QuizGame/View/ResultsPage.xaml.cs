using QuizGame.ViewModel;

namespace QuizGame.View;

public partial class ResultsPage : ContentPage
{
    public ResultsPage(ResultsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
