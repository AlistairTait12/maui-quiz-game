using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizGame.Model;
using QuizGame.Service;
using QuizGame.View;

namespace QuizGame.ViewModel;

public partial class QuestionViewModel : BaseViewModel
{
    public IEnumerable<Question> Questions { get; set; }

    public QuestionViewModel(IQuestionService questionService)
    {
        Questions = questionService.GetQuestions();
        CurrentQuestion = Questions.FirstOrDefault();
        UpdateScoreMessage();
    }

    [ObservableProperty]
    Question currentQuestion;

    [ObservableProperty]
    int score;

    [ObservableProperty]
    string scoreMessage;

    [RelayCommand]
    public async Task SubmitAnswer(string submittedAnswer)
    {
        if (Equals(CurrentQuestion.CorrectAnswer, submittedAnswer))
        {
            Score++;
        }

        UpdateScoreMessage();

        if (CurrentQuestion == Questions.Last())
        {
            await Shell.Current.GoToAsync(nameof(ResultsPage));
        }
        else
        {
            var currentIndex = Questions.ToList().IndexOf(CurrentQuestion);
            CurrentQuestion = Questions.ElementAt(currentIndex + 1);
        }
    }

    private void UpdateScoreMessage()
    {
        ScoreMessage = $"{Score} out of {Questions.ToList().Count}";
    }
}
