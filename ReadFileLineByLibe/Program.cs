using System;
using System.IO;

public class ReadFileLineByLine
{
    public static void Main()
    {
        string fileName = @"D:\Test.txt";

        string[] lines = File.ReadAllLines(fileName);
        Console.WriteLine(String.Join(Environment.NewLine, lines));
    }
}