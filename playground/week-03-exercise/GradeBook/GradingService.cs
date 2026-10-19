public class GradingService(IGradeStore store)
{
    public void Add(int score)
    {
        store.Add(score);
    }

    public int Average()
    {
        int[] scores = store.All();
        if (scores.Length == 0)
            return 0;

        int total = 0;
        foreach (int score in scores)
            total += score;

        return total / scores.Length;
    }
}
