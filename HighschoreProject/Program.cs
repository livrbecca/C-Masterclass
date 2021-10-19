using System;

namespace HighschoreProject
{
    class Program
    {

        static int highscore = 300;
        static string highscorePlayer = "Liv";

        static void Main(string[] args)
        {
            CheckHighscore(750, "lisa");
        }

        public static void CheckHighscore(int score, string playerName)
        {
            
           if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine($"New highscore is {score}\nNew highscore holder is {playerName}");
            } else
            {
                Console.WriteLine($"Old highscore of {highscore} by {highscorePlayer} could not be broken");
            }
        }
    }
}
