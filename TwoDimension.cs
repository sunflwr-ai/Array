using System;
public class TwoDimension
{
    public void TwoD()
    {
        int[][] arr = new int[2][];
        arr[0] = new int[] { 1, 2, 3 };
        arr[1] = new int[] { 4, 3 };

        Console.WriteLine("Jagged Array Elements of 2D:");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}