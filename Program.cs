using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
       static string GameName = "timesUp";
       static int Score = 0;
      static  int Health = 100;
       static int Shield = 100;
       static int Lives = 3;
      static int Multiplier = 2;
        static int Damege = 10;
        
        static void Main(string[] args)
        {
            Console.WriteLine(GameName);
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            damege();
            multiplier();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            damege();
            multiplier();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            damege();
            multiplier();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            damege();
            multiplier();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();
            showHUD();
            damege();
            multiplier();
            showHUD();
            multiplier();
            damege();
            showHUD();
            multiplier();
            damege();


        }
        static void showHUD()
        {
            
            Console.WriteLine("score = " + Score);
            Console.WriteLine("health = " + Health);
            Console.WriteLine("shield = " + Shield);
            Console.WriteLine("lives = " + Lives);

            Console.ReadKey();
        }
        static void multiplier()
        {
            Score += 100 * Multiplier; 
            
        }

        static void damege()
        {

            if (Shield > 0)
            {
                Shield -= Damege;
            }
            else
            {
                Health -= Damege;
            }

            if (Health == 0)
            {
                Lives -= 1;
                Health = 100;
                Shield = 100;
            }
        }
    }
}
