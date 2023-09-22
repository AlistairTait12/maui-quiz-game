using QuizGame.ViewModel;

namespace QuizGame.View;

public partial class QuestionView : ContentPage
{
    public QuestionView(QuestionViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
