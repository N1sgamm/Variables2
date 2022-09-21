using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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
            int keyPoints;
            int combo;

            // Initialization
            gameTitle = "Gaming Time";
            studioName = "Zackery Goodwin";
            score = 0;
            health = 100f;
            lives = 3;
            scoreMultiplier = 1.0f;
            keyPoints = 100;
            combo = 0;

            // Display
            Console.WriteLine(gameTitle);
            Console.WriteLine("A game by "+studioName);
            Console.WriteLine();
            Console.WriteLine("You are a gamer. You need points to survive.");
            Console.WriteLine("Your current score is "+score+".");
            Console.WriteLine("Your current health is "+health+"%.");
            Console.WriteLine("You currently have "+lives+" lives, somehow."); //add modification for context
            Console.WriteLine("Your current score multiplier is "+scoreMultiplier+"x.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true); //continue
            Console.Clear();

            Console.WriteLine("Press any key to gain points.");
            Console.WriteLine();
            Console.ReadKey(true);
            combo = combo + 1;
            scoreMultiplier = combo / 10 + 1;
            Console.WriteLine("You gain "+keyPoints+" points.");
            score = (int)(score + keyPoints * scoreMultiplier);
            Console.WriteLine("Your current score is "+score+"."); // edit for grammar
            Console.ReadKey(true);
            combo = combo + 1;
            scoreMultiplier = combo / 10 + 1;
            Console.Clear();

            Console.WriteLine("Press any key to gain points.");
            Console.WriteLine();
            Console.WriteLine("You gain "+keyPoints+" points.");
            score = (int)(score + keyPoints * scoreMultiplier);
            Console.WriteLine("Your current score is "+score+".");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Press any key to gain points.");
            Console.WriteLine();
            Console.WriteLine("You gain "+keyPoints+" points.");
            combo = combo + 1;
            Console.WriteLine("You got a "+combo+"x combo. Your multiplier is now "+scoreMultiplier+"x.");
            score = (int)(score + keyPoints * scoreMultiplier);
            Console.WriteLine("Your current score is "+score+".");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You gain "+keyPoints+" points.");
            score = (int)(score + keyPoints * scoreMultiplier);
            Console.WriteLine("Your current score is "+score+".");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You pressed the key too hard and hurt your finger.");

            Console.WriteLine("You gain "+keyPoints+" points.");
            score = (int)(score + keyPoints * scoreMultiplier);
            Console.WriteLine("Your current score is "+score+".");
            Console.ReadKey(true);
            Console.Clear();

            Console.ReadKey(true); // end game
        }
    }
}
