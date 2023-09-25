namespace QuizGame.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> listToShuffle)
    {
        var result = listToShuffle.ToArray();
        var rand = new Random();
        for (int i = result.Length - 1; i > 0; i--)
        {
            var k = rand.Next(i + 1);
            var val = result[k];
            result[k] = result[i];
            result[i] = val;
        }

        return result.AsEnumerable();
    }
}
