using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables

            string namep1 = "";
            int p1points = 0,
                p1rnd1,
                p1rnd2,
                p1rndt = 0;

            string namep2 = "";
            int p2points = 0,
                p2rnd1,
                p2rnd2,
                p2rndt = 0;

            string namep3 = "";
            int p3points = 0,
                p3rnd1,
                p3rnd2,
                p3rndt = 0;

            string namep4 = "";
            int p4points = 0,
                p4rnd1,
                p4rnd2,
                p4rndt = 0;

            string gameconfirm;
            string AOP;
            int NOPoints;
            int rounds = 1;


            //voids

            void Continue()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press [enter] to continue!");
                Console.ReadLine();
                Console.Clear();
            }

            void Opening()
            {
                Console.WriteLine();
                Console.WriteLine("Are you sure that you want to play this game? (y/n)");
                gameconfirm = Console.ReadLine();
            }

            void Rules()
            {
                Console.WriteLine();
                Console.WriteLine("The Rules:");
                Console.WriteLine();
                Console.WriteLine("Rule 1: all the players get 2 dices with each 10 sides.");
                Console.WriteLine("Rule 2: you play this game with 2 to 4 people, more or less wont work.");
                Console.WriteLine("Rule 3: you can chose the amount of rounds that you want to play.");
                Console.WriteLine("Rule 4: the person with the most points at the end wins!");
            }

            void NOP()
            {
                Console.WriteLine();
                Console.WriteLine("With how many people do you want to play? (min 2 / max 4)");
                AOP = Console.ReadLine();
            }

            void Names()
            {
                if(AOP == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 1, what is your name?");
                    namep1 = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Player 2, what is your name?");
                    namep2 = Console.ReadLine();
                }
                if (AOP == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 1, what is your name?");
                    namep1 = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Player 2, what is your name?");
                    namep2 = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Player 3, what is your name?");
                    namep3 = Console.ReadLine();
                }
                if (AOP == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("Player 1, what is your name?");
                    namep1 = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Player 2, what is your name?");
                    namep2 = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Player 3, what is your name?");
                    namep3 = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Player 4, what is your name?");
                    namep4 = Console.ReadLine();
                }
            }

            void dice()
            {
                Random rnd = new Random();

                p1rnd1 = rnd.Next(1, 11);
                p1rnd2 = rnd.Next(1, 11);
                p1rndt = p1rnd1 + p1rnd2;

                p2rnd1 = rnd.Next(1, 11);
                p2rnd2 = rnd.Next(1, 11);
                p2rndt = p2rnd1 + p2rnd2;

                p3rnd1 = rnd.Next(1, 11);
                p3rnd2 = rnd.Next(1, 11);
                p3rndt = p3rnd1 + p3rnd2;

                p4rnd1 = rnd.Next(1, 11);
                p4rnd2 = rnd.Next(1, 11);
                p4rndt = p4rnd1 + p4rnd2;
            }

            void RoundWinner()
            {
                if (p1rndt > p2rndt)
                {
                    if(p1rndt > p3rndt)
                    {
                        if (p1rndt > p4rndt)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep1 + " has the highest combined points,");
                            Console.WriteLine("that means that " + namep1 + " has won this round!");
                            p1points++;
                            rounds++;
                        }
                    }
                }

                if (p2rndt > p1rndt)
                {
                    if (p2rndt > p3rndt)
                    {
                        if (p2rndt > p4rndt)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep2 + " has the highest combined points,");
                            Console.WriteLine("that means that " + namep2 + " has won this round!");
                            p2points++;
                            rounds++;
                        }
                    }
                }

                if (p3rndt > p2rndt)
                {
                    if (p3rndt > p1rndt)
                    {
                        if (p3rndt > p4rndt)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep3 + " has the highest combined points,");
                            Console.WriteLine("that means that " + namep3 + " has won this round!");
                            p3points++;
                            rounds++;
                        }
                    }
                }

                if (p4rndt > p2rndt)
                {
                    if (p4rndt > p3rndt)
                    {
                        if (p4rndt > p1rndt)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep4 + " has the highest combined points,");
                            Console.WriteLine("that means that " + namep4 + " has won this round!");
                            p4points++;
                            rounds++;
                        }
                    }
                }
            }

            void MaxPoints()
            {
                Console.WriteLine();
                Console.WriteLine("what do you want to be the max combined points?");
                NOPoints = Convert.ToInt32(Console.ReadLine());
            }

            void Round()
            {
                Console.WriteLine();
                Console.WriteLine("Round " + rounds);
                Console.WriteLine();

                if (AOP == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine(namep1 + " has roled a " + p1rnd1 + " and a " + p1rnd2);
                    Console.WriteLine("which makes a total of " + p1rndt);

                    Console.WriteLine();
                    Console.WriteLine(namep2 + " has roled a " + p2rnd1 + " and a " + p2rnd2);
                    Console.WriteLine("which makes a total of " + p2rndt);
                }

                if (AOP == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine(namep1 + " has roled a " + p1rnd1 + " and a " + p1rnd2);
                    Console.WriteLine("which makes a total of " + p1rndt);

                    Console.WriteLine();
                    Console.WriteLine(namep2 + " has roled a " + p2rnd1 + " and a " + p2rnd2);
                    Console.WriteLine("which makes a total of " + p2rndt);

                    Console.WriteLine();
                    Console.WriteLine(namep3 + " has roled a " + p3rnd1 + " and a " + p3rnd2);
                    Console.WriteLine("which makes a total of " + p3rndt);
                }

                if (AOP == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine(namep1 + " has roled a " + p1rnd1 + " and a " + p1rnd2);
                    Console.WriteLine("which makes a total of " + p1rndt);

                    Console.WriteLine();
                    Console.WriteLine(namep2 + " has roled a " + p2rnd1 + " and a " + p2rnd2);
                    Console.WriteLine("which makes a total of " + p2rndt);

                    Console.WriteLine();
                    Console.WriteLine(namep3 + " has roled a " + p3rnd1 + " and a " + p3rnd2);
                    Console.WriteLine("which makes a total of " + p3rndt);

                    Console.WriteLine();
                    Console.WriteLine(namep4 + " has roled a " + p4rnd1 + " and a " + p4rnd2);
                    Console.WriteLine("which makes a total of " + p4rndt);
                }

            }

            void Points()
            {
                if (AOP == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("The score right now is:");
                    Console.WriteLine();
                    Console.WriteLine(namep1 + " with" + p1points + " right now!");
                    Console.WriteLine(namep2 + " with" + p2points + " right now!");
                }

                if (AOP == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("The score right now is:");
                    Console.WriteLine();
                    Console.WriteLine(namep1 + " with" + p1points + " right now!");
                    Console.WriteLine(namep2 + " with" + p2points + " right now!");
                    Console.WriteLine(namep3 + " with" + p3points + " right now!");
                }

                if(AOP == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("The score right now is:");
                    Console.WriteLine();
                    Console.WriteLine(namep1 + " with" + p1points + " right now!");
                    Console.WriteLine(namep2 + " with" + p2points + " right now!");
                    Console.WriteLine(namep3 + " with" + p3points + " right now!");
                    Console.WriteLine(namep4 + " with" + p4points + " right now!");
                }
            }

            void winner()
            { 
                if (p1points > p2points)
                {
                    if (p1points > p3points)
                    {
                        if (p1points > p4points)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep1 + " has won the most rounds,");
                            Console.WriteLine("that means that " + namep1 + " has won this game!!!");
                        }
                    }
                }

                if (p2points > p1points)
                {
                    if (p2points > p3points)
                    {
                        if (p2points > p4points)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep2 + " has won the most rounds,");
                            Console.WriteLine("that means that " + namep2 + " has won this game!!!");
                        }
                    }
                }

                if (p3points > p2points)
                {
                    if (p3points > p1points)
                    {
                        if (p3points > p4points)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep3 + " has won the most rounds,");
                            Console.WriteLine("that means that " + namep3 + " has won this game!!!");
                        }
                    }
                }

                if (p4points > p2points)
                {
                    if (p4points > p3points)
                    {
                        if (p4points > p1points)
                        {
                            Console.WriteLine();
                            Console.WriteLine(namep4 + " has won the most rounds,");
                            Console.WriteLine("that means that " + namep4 + " has won this game!!!");
                        }
                    }
                }
            }

            //game

            Opening();
            if (gameconfirm == "y")
            {
                Console.Clear();
                Rules();
                Continue();
                NOP();
                Console.Clear();
                Names();
                Continue();
                MaxPoints();
                Continue();

                do
                {
                    dice();
                    Round();
                    RoundWinner();
                    Continue();
                    Points();
                    Continue();
                } while (rounds <= NOPoints);

                winner();
                Continue();

            }
            else
            {
                Console.Clear();
            }

        }
    }
}
