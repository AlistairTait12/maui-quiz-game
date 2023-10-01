using QuizGame.View;

namespace QuizGame;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // TODO: Register routes here
        Routing.RegisterRoute(nameof(QuestionPage), typeof(QuestionPage));
        Routing.RegisterRoute(nameof(ResultsPage), typeof(ResultsPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
