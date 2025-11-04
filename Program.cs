using System;

public class Program
{
    public static void Main(string[] args)
    {
       OneDimension one = new OneDimension();
       one.OneD();

         TwoDimension two = new TwoDimension();
        two.TwoD();

         ThreeDimension three = new ThreeDimension();
        three.ThreeD();

        JaggedArray obj = new JaggedArray();
        obj.ShowJagged();
    }
}