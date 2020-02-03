using System;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'Enter' for Player 1 to roll a dice ");
            Console.ReadLine();
            Random player1 = new Random();
            int n = player1.Next(1, 7);
            Console.WriteLine($"Player 1 rolled {n}\n");
            Console.WriteLine("Press 'Enter' for Player 2 to roll a dice ");
            Console.ReadLine();
            Random player2 = new Random();
            int m = player2.Next(1, 7);
            Console.WriteLine($"Player 2 rolled {m}\n");
            
            if (m>n)
            {
                Console.WriteLine("Player 2 won the game");
            }
            else if (m<n)
            {
                Console.WriteLine("Player 1 won the game");
            }
            else if (m==n)
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}
