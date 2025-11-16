using System;

public class Program
{
    public static void Main(string[] args)
    {
        OneDimension one = new OneDimension();
        one.OneD();

        // TwoDimension two = new TwoDimension();
        //two.TwoD();

        // ThreeDimension three = new ThreeDimension();
        //three.ThreeD();

        //JaggedArray obj = new JaggedArray();
        //obj.ShowJagged();

        // BankAccount ba = new BankAccount();
        // ba.Account();


        AverageCalculator cal = new AverageCalculator();
        double avg = cal.FindAverage(5, 10, 15, 20);
        Console.WriteLine("Average = " + avg);

        MessagePrinter mp = new MessagePrinter();
        mp.PrintMessage("Hey,", "Donkey", "where", "are", "you?");
    

    }
}