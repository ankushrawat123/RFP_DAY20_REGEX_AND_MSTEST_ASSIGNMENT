﻿// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;
Console.WriteLine("WELCOME TO MOOD ANALYZER PROGRAM ");
Console.WriteLine("Enter \n1 FOR MOODANALYZER SAD,HAPPY & OTHER MOOD PROGRAM \n2 FOR MOODANALYZER INVALID INPUT PROGRAM\n3 FOR CUSTOM EXCEPTION PROGRAM\n ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        MoodAnalyser mood = new MoodAnalyser("I am feeling happy");
        string result = mood.analyseMood();
        Console.WriteLine(result);
        break;

    case 2:
        InvalidMood Moodobj2 = new InvalidMood(null);
        string result2 = Moodobj2.MoodCheck();
        Console.WriteLine(result2);
        break;

    case 3:
        MoodAnalyze3 Moodobj3 = new MoodAnalyze3();
        string result3 = Moodobj3.analyzeMood3();
        Console.WriteLine(result3);
        break;
}