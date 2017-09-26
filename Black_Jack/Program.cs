using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
public class Program
{
    public static int[] humanCards = new int[10];
    public static int[] computerCards = new int[10];
    public static int humanScore = 0;
    public static int computerScore = 0;
    public static int count = 1;
    public static string cont = "";

    public static Random randomCards = new Random();
        
    public static void GameStart()
    {
           
        humanCards[0] = GameDeal();
        humanCards[1] = GameDeal();
            
        computerCards[0] = GameDeal();
        computerCards[1] = GameDeal();
     
        humanScore = humanCards[0] + humanCards[1];
        computerScore = computerCards[0] + computerCards[1];

        do
        {
            Console.WriteLine("Human Cards: " + humanCards[0] + " : " + humanCards[1] + " = " + humanScore);
            Console.WriteLine("Computer Cards: " + computerCards[0] + " : " + computerCards[1] + " = " + computerScore);
            Console.WriteLine("Do you want another card (y/n)?");
            cont = Console.ReadLine().ToLower();

        } while (!cont.Equals("y") && !cont.Equals("n")) ;
            
            GameStatus();
    }

    public static int GameDeal()
    {
        int Card = randomCards.Next(1, 10);
        return Card;
    }

    public static void GameStatus()
    {
        if (cont.Equals("y"))
        {
            GameHit();
        }
        else if (cont.Equals("n"))
        {
            DisplayScores();
            ShowCards showCards = new ShowCards();
            Console.WriteLine(showCards.Check(humanScore, computerScore));
        }
        Console.WriteLine("\nWould you like to play again (y/n)?");
        PlayAgain();
        Console.ReadLine();
    }


    public static void GameHit()
    {
        count += 1;
        humanCards[count] = GameDeal();
        computerCards[count] = GameDeal();

        humanScore += humanCards[count];
        computerScore += computerCards[count];

        Console.WriteLine("\nHit: " + humanCards[count] + " Your total is " + humanScore);

        if (humanScore < 21)
        {
            do
            {
                Console.WriteLine("\nDo you want another card (y/n)?");
                cont = Console.ReadLine().ToLower();
            } while (!cont.Equals("y") && !cont.Equals("n"));
            GameStatus();
        }
        else if (humanScore > 21)
        {
            Console.WriteLine("\nHuman lost.");
        }
        else if (humanScore < computerScore && computerScore <= 21)
        {
            Console.WriteLine("\nHuman lost.");
        }
    }

    private static void DisplayScores()
    {
        Console.WriteLine("\nThe computer takes a card: " + computerCards[count]);
        Console.WriteLine("Human score: " + humanScore);
        Console.WriteLine("Computer score: " + computerScore);
    }

    public static void PlayAgain()
    {
        string playAgain = "";
        do
        {
            playAgain = Console.ReadLine().ToLower();
        } while (!playAgain.Equals("y") && !playAgain.Equals("n"));
        if (playAgain.Equals("y"))
        {
            Console.WriteLine("\nPress enter to restart the game!");
            Console.ReadLine();
            Console.Clear();
            computerScore = 0;
            count = 1;
            humanScore = 0;
            GameStart();
        }
        else if (playAgain.Equals("n"))
        {
            
            Environment.Exit(0);
        }

    }

    public static void Main(string[] args)
    {

        GameStart();
    }

}
}
