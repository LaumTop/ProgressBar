using System;
using System.Threading;

namespace ProgressBar;
class main
{
    //Version: 1.0
    //Author: https://github.com/LaumTop

    public static int procents;
    static void ProgressBar()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Press enter to start!");
        Console.ReadLine();
        Console.Clear();
        var symbol = "#";

        for (int a = 0; a <= 100; a++)
        {
            procents = a;
            Console.Write($"Progress: [{procents}%] ");

            int completedBlocks = procents / 10;
            int remainingBlocks = 10 - completedBlocks;

            Console.Write("[");
            Console.Write(new string(symbol[0], completedBlocks));
            Console.Write(new string('.', remainingBlocks));
            Console.Write("]");

            Thread.Sleep(100);
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        Console.WriteLine();
        Console.ResetColor();
    }
    static void Main(String[] args)
    {
        Thread ProgressBarThread = new Thread(ProgressBar);

        ProgressBarThread.Start();

        //This code is executed during the loading process.

        ProgressBarThread.Join();
    }
}