/*Your task is to program a C# game Cockroach, Foot, Nuke. 
The game has same rules as Rock, Paper Scissors – 
cockroach loses to foot, 
foot loses to nuke and 
nuke loses to cockroach.*/
using System;
namespace open_exercise
{
    class CFN
    {
        static void Main(string[] args)
        {
            string playOrNo = "";
            int usercount = 0;
            int computercount = 0;
            Console.WriteLine("This is a mockup of rock paper scissors.");
            while (playOrNo != "NO")
            {
                Console.WriteLine("Select any one:\n1: COCKROACH\n2: FOOT\n3: NUKE");
                string[] computer = new string[3] {"COCKROACH","FOOT","NUKE"};
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                Console.WriteLine("Enter your choice:");
                string user_choice = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer:" + computer[n]);

                if (user_choice == "COCKROACH" && computer[n] == "NUKE")
                {
                    Console.WriteLine("YOU WIN!");
                    usercount += 1;
                }
                else if (user_choice == "COCKROACH" && computer[n] == "FOOT")
                {
                    Console.WriteLine("YOU SUCK");
                    computercount += 1;
                }
                else if (user_choice == "FOOT" && computer[n] == "COCKROACH")
                {
                    Console.WriteLine("YOU WIN!");
                    usercount += 1;
                }
                else if (user_choice == "FOOT" && computer[n] == "NUKE")
                {
                    Console.WriteLine("YOU SUCK");
                    computercount += 1;
                }
                else if (user_choice == "NUKE" && computer[n] == "COCKROACH")
                {
                    Console.WriteLine("YOU SUCK");
                    computercount += 1;
                }
                else if (user_choice == "NUKE" && computer[n] == "FOOT")
                {
                    Console.WriteLine("YOU WIN!");
                    usercount += 1;
                }
                else
                {
                    Console.WriteLine("YOU GUYS THINK ALIKE!");
                }
                Console.WriteLine("Do you want to continue(YES/NO):");
                playOrNo= Console.ReadLine().ToUpper();
                Console.WriteLine("\n");
            }
            Console.WriteLine("User won " + usercount + " times.");
            Console.WriteLine("Computer won " + computercount + " times.");
        }
    }
}