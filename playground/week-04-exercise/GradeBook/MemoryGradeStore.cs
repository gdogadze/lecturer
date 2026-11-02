public class MemoryGradeStore : IGradeStore
{
    private readonly List<int> _scores = [];

    public void Add(int score)
    {
        _scores.Add(score);
    }

    public int[] All()
    {
        return [.. _scores];
    }
}
