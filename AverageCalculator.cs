using System;

public class AverageCalculator
{
    public double FindAverage(params int[] numbers)
    {
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return (double)sum / numbers.Length;
    }
}
