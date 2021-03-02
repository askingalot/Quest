using System;

namespace Quest
{
    public class Challenge
    {
        private string _text;
        private int _correctAnswer;
        private int _awesomenessChange;

        public Challenge(string text, int correctAnswer, int awesomenessChange)
        {
            _text = text;
            _correctAnswer = correctAnswer;
            _awesomenessChange = awesomenessChange;
        }

        public void RunChallenge(Player player)
        {
            Console.Write($"{_text}: ");
            string answer = Console.ReadLine();

            int numAnswer;
            bool isNumber = int.TryParse(answer, out numAnswer);

            Console.WriteLine();
            if (isNumber && numAnswer == _correctAnswer)
            {
                Console.WriteLine("Well Done!");
                player.Awesomness += _awesomenessChange;
            }
            else
            {
                Console.WriteLine("You have failed the challenge, there will be consequences.");
                player.Awesomness -= _awesomenessChange;
            }

            Console.WriteLine(player.GetPlayerStatus());
            Console.WriteLine();
        }
    }
}