namespace GradeBook.Tests;

public class GradeViewModelTests
{
    [Fact]
    public void Add_updates_average_text()
    {
        var vm = new GradeViewModel(new GradingService(new MemoryGradeStore()));
        vm.ScoreText = "10";
        vm.Add();
        vm.ScoreText = "8";
        vm.Add();

        Assert.Equal("საშუალო: 9", vm.AverageText);
        Assert.Equal("", vm.ScoreText);
    }

    [Fact]
    public void Add_ignores_text_that_is_not_an_integer()
    {
        var vm = new GradeViewModel(new GradingService(new MemoryGradeStore()));
        vm.ScoreText = "აბა";
        vm.Add();

        Assert.Equal("საშუალო: 0", vm.AverageText);
        Assert.Equal("აბა", vm.ScoreText);
    }

    [Fact]
    public void Add_raises_property_changed_for_average_text()
    {
        var vm = new GradeViewModel(new GradingService(new MemoryGradeStore()));
        var names = new List<string>();
        vm.PropertyChanged += (_, e) => names.Add(e.PropertyName!);

        vm.ScoreText = "10";
        vm.Add();

        Assert.Contains(nameof(GradeViewModel.AverageText), names);
    }
}
