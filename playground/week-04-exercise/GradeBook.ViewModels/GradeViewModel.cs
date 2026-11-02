using System.ComponentModel;

public class GradeViewModel(GradingService grading) : INotifyPropertyChanged
{
    private string _scoreText = "";
    private string _averageText = "საშუალო: 0";

    public event PropertyChangedEventHandler? PropertyChanged;

    public string ScoreText
    {
        get => _scoreText;
        set => Set(ref _scoreText, value, nameof(ScoreText));
    }

    public string AverageText => _averageText;

    public void Add()
    {
        if (!int.TryParse(ScoreText, out int score))
            return;

        grading.Add(score);
        ScoreText = "";
        _averageText = $"საშუალო: {grading.Average()}";
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AverageText)));
    }

    private void Set(ref string field, string value, string name)
    {
        if (field == value)
            return;

        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
