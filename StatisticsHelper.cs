namespace apbdrepo;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        int sum = 0;

        foreach (int v in values)
        {
            sum += v;
        }

        return (double)sum / values.Length;
    }
}