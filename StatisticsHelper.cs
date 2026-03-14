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
    
    public static int CalculateMax(int[] values)
    {
        int max = values[0];

        foreach (int v in values)
        {
            if (v > max)
            {
                max = v;
            }
        }

        return max;
        Console.WriteLine("Max value calculated");
    }

    public static int CalculateMin(int[] values)
    {
        int min = values[0];
        foreach (int v in values)
        {
            if (v < min)
            {
                min = v;
            }
        }
        
        return 0;
    }
    
    
}