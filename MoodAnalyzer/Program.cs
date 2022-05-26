// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;
Console.WriteLine("WELCOME TO MOOD ANALYZER PROGRAM ");
MoodAnalyser mood = new MoodAnalyser("I am feeling happy");
string result = mood.analyseMood();
Console.WriteLine(result);
