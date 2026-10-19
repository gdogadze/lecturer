using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IGradeStore, MemoryGradeStore>();
services.AddTransient<GradingService>();

using ServiceProvider provider = services.BuildServiceProvider();
GradingService grading = provider.GetRequiredService<GradingService>();

grading.Add(10);
grading.Add(9);
grading.Add(8);
Console.WriteLine(grading.Average());
