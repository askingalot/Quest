﻿using System;
using System.Collections.Generic;

namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge twoPlustwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );

            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            Player thePlayer = new Player("Jack");

            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlustwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle
            };

            foreach (Challenge challenge in challenges)
            {
                challenge.RunChallenge(thePlayer);
            }

            if (thePlayer.Awesomness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (thePlayer.Awesomness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
        }
    }
}