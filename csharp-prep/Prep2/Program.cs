using System;

class Program
{static void Main(string[] args)
    {Console.Write("Grade?? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";
        if (percent >= 90)
        {letter = "A";}
        else if (percent >= 80)
        {letter = "B";}
        else if (percent >= 70)
        {letter = "C";}
        else if (percent >= 60)
        {letter = "D";}
        else
        {letter = "F";}
        Console.WriteLine($"Total grade: {letter}");
        if (percent >= 70)
        {Console.WriteLine("Failed!! JKJK you got it!! ");}
        else
        {Console.WriteLine("Akward...");}}}