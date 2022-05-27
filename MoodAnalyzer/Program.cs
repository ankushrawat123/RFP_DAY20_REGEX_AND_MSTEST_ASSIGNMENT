// See https://aka.ms/new-console-template for more information
using MoodAnalyzer;
Console.WriteLine("WELCOME TO MOOD ANALYZER PROGRAM ");
Console.WriteLine("Enter \n1 FOR MOODANALYZER \n2 FOR MOODANALYZER ");
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
}