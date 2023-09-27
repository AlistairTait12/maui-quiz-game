using QuizGame.ViewModel;

namespace QuizGame.View;

public partial class QuestionPage : ContentPage
{
    public QuestionPage(QuestionViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
