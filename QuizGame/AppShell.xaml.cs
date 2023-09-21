using QuizGame.View;

namespace QuizGame;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		// TODO: Register routes here
		Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
	}
}
