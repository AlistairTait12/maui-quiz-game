using QuizGame.Service;
using QuizGame.View;
using QuizGame.ViewModel;

namespace QuizGame;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<AboutPage>();
        builder.Services.AddTransient<IQuestionService, FakeQuestionService>();
        builder.Services.AddSingleton<QuestionView>();
        builder.Services.AddSingleton<QuestionViewModel>();

        return builder.Build();
    }
}
