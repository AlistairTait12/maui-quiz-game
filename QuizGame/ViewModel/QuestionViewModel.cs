using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizGame.Model;
using QuizGame.Service;
using QuizGame.View;

namespace QuizGame.ViewModel;

public partial class QuestionViewModel : BaseViewModel
{
    private IEnumerable<Question> _questions;
    private int _score;

    public QuestionViewModel(IQuestionService questionService)
    {
        _questions = questionService.GetQuestions();
        CurrentQuestion = _questions.FirstOrDefault();
        UpdateScoreMessage();
    }

    [ObservableProperty]
    Question currentQuestion;

    [ObservableProperty]
    string scoreMessage;

    [RelayCommand]
    public async Task SubmitAnswer(string submittedAnswer)
    {
        if (Equals(CurrentQuestion.CorrectAnswer, submittedAnswer))
        {
            _score++;
        }

        UpdateScoreMessage();

        if (CurrentQuestion == _questions.Last())
        {
            await ProceedToResultsPage();
        }
        else
        {
            var currentIndex = _questions.ToList().IndexOf(CurrentQuestion);
            CurrentQuestion = _questions.ElementAt(currentIndex + 1);
        }
    }

    private async Task ProceedToResultsPage()
    {
        var result = new ResultsModel()
        {
            UserScore = _score,
            TotalQuestions = _questions.Count()
        };

        await Shell.Current.GoToAsync(nameof(ResultsPage),
            new Dictionary<string, object>
            {
                    { "ResultsModel", result }
            });
    }

    private void UpdateScoreMessage()
    {
        ScoreMessage = $"{_score} out of {_questions.Count()}";
    }
}
