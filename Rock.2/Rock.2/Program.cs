using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, Computer;
            int randomInt;
           
            String names;
            Console.Write("Please enter your Name: ");
            names = Console.ReadLine();

            bool PlayAgain = true;

            while (PlayAgain)
            {
                int PlayerScore = 0;
                int ScoreComputer = 0;


                while (PlayerScore < 3 && ScoreComputer < 3)
                {
                    Console.Write("Choose between Rock, Paper and SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random random = new Random();
                    randomInt = random.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            Computer = "ROCK";
                            Console.WriteLine("Computer choose Rock");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer choose Rock");
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine(names + "Wins!\n");
                                PlayerScore++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer Wins!\n");
                                ScoreComputer++;
                            }
                            break;

                        case 2:
                            Computer = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer choose PAPER");
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer Wins!\n\n");
                                ScoreComputer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine(names + "Wins!\n\n");
                                PlayerScore++;
                                
                            }
                            break;


                        case 3:
                            Computer = "SCISSORS";
                            Console.WriteLine("Computer choose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine(names + "Wins!\n\n");
                                PlayerScore++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                               
                                Console.WriteLine("ScoreComputer Wins!\n\n");
                                ScoreComputer++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invaild entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", PlayerScore, ScoreComputer);

                }
                if (PlayerScore == 3)
                {
                    Console.WriteLine(names + "WON!!! ");
                }
                else if (ScoreComputer == 3)
                {
                    Console.WriteLine("Computer Won!!");
                }
                else
                {

                }
                Console.WriteLine("You want TO play again?[Y/N]");
                string loop = Console.ReadLine();
                if (loop == "Y")
                {
                    PlayAgain = true;
                    Console.Clear();
                }
                else if (loop == "N")
                {
                    PlayAgain = false;
                }

            }

        }
    }
}