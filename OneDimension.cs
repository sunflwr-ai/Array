using System;
public class OneDimension
{
    public void OneD()
    {
        int[][] arr = new int[1][];
        arr[0] = new int[] { 1, 2, 3 };

        Console.WriteLine("Elements are :");
        for (int i = 0; i < arr[0].Length; i++)
        {
            Console.WriteLine(arr[0][i]);
        }
    }
}
