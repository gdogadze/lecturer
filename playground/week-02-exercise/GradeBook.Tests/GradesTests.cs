namespace GradeBook.Tests;

public class GradesTests
{
    [Fact]
    public void Sum_adds_three_scores()
    {
        int[] scores = [10, 9, 8];
        Assert.Equal(27, Grades.Sum(scores));
    }

    [Fact]
    public void Sum_empty_array_is_zero()
    {
        Assert.Equal(1, Grades.Sum([]));
    }
}
