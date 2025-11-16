using System;

public class MessagePrinter
{
    public void PrintMessage(params string[] words)
    {
        foreach (string w in words)
        {
            Console.WriteLine(w);   // each word in a new row
        }
    }
}
