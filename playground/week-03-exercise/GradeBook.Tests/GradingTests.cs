using Microsoft.Extensions.DependencyInjection;

namespace GradeBook.Tests;

public class GradingTests
{
    [Fact]
    public void Average_of_three_scores_is_nine()
    {
        var grading = new GradingService(new MemoryGradeStore());
        grading.Add(10);
        grading.Add(9);
        grading.Add(8);

        Assert.Equal(9, grading.Average());
    }

    [Fact]
    public void Average_of_empty_store_is_zero()
    {
        var grading = new GradingService(new MemoryGradeStore());

        Assert.Equal(0, grading.Average());
    }

    [Fact]
    public void Container_shares_one_store()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IGradeStore, MemoryGradeStore>();
        services.AddTransient<GradingService>();

        using ServiceProvider provider = services.BuildServiceProvider();
        GradingService first = provider.GetRequiredService<GradingService>();
        first.Add(10);
        GradingService second = provider.GetRequiredService<GradingService>();
        second.Add(8);

        Assert.Equal(9, first.Average());
        Assert.NotSame(first, second);
    }
}
