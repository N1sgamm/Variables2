using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Variables2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            string gameTitle;
            string studioName;
            int score;
            float health;
            int lives;
            float scoreMultiplier;

            // Initialization
            gameTitle = "Gaming Time";
            studioName = "Zackery Goodwin";
            score = 0;
            health = 100;
            lives = 3;
            scoreMultiplier = 1.0f;

            // Display
            Console.WriteLine(gameTitle);
            Console.WriteLine("A game by "+studioName);
            Console.WriteLine();
            Console.WriteLine("You are a gamer. You need points to survive.");
            Console.WriteLine("Your current score is "+score+".");
            Console.WriteLine("Your current health is "+health+"%.");
            Console.WriteLine("You currently have "+lives+" lives, somehow."); //add modification for context
            Console.WriteLine("Your current score multiplier is "+scoreMultiplier);

            Console.ReadKey(true); // end game
        }
    }
}
