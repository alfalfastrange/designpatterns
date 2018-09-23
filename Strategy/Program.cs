using System;
using Strategy.Rules;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            AboutBox aboutBox = new AboutBox(new MinCharacterRules());
            aboutBox.Title = "This is a good title";
            aboutBox.About = "This is a good about section";
            aboutBox.Version = 9;
            bool isAboutBoxValid = aboutBox.ExecuteRules();
            Console.Write($"About box is valid? {isAboutBoxValid}", isAboutBoxValid == true);
            Console.ReadLine();

            MessageBox messageBox = new MessageBox(new MaxCharacterRules());
            messageBox.ErrorMessage = "This complicated error message is far too long to be able to be shown effectively in the message box in it's current size.";
            bool isMessageBoxValid = messageBox.ExecuteRules();
            Console.Write($"Message box is valid? {isMessageBoxValid}", isMessageBoxValid == true);
            Console.ReadLine();
        }
    }
}