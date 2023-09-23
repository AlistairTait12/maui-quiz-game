using QuizGame.View;

namespace QuizGame;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // TODO: Register routes here
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        Routing.RegisterRoute(nameof(QuestionView), typeof(QuestionView));
        Routing.RegisterRoute(nameof(ResultsPage), typeof(ResultsPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
