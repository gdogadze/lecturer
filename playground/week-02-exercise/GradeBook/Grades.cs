public static class Grades
{
    public static int Sum(int[] scores)
    {
        int total = 0;
        foreach (int score in scores)
        {
            total += score;
            Console.WriteLine($"Added {score}, running total = {total}");
        }
        Console.WriteLine($"Sum = {total}");
        return total;
    }
}
