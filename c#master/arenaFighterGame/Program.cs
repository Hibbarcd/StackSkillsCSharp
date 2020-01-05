using System;

namespace arenaFighterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            string fighterName = "Sargon the wicked";
            string barbName = "Ulf the Strong";
            string legionName = "Gaius Magnus";

            int fighterHealth = 50;
            int barbarianHealth = 70;

            int fighterDmg = 1;
            int barbDmg = 2;
            int legionDmg = 3;

            bool gameOver = false;

            while(!gameOver) {
                fighterDmg = rng.Next(1,8);
                barbDmg = rng.Next(1,12);
                legionDmg = rng.Next(2,6);

                fighterHealth -= barbDmg;
                barbarianHealth -= fighterDmg;

                System.Console.WriteLine($"{fighterName} inflicts {fighterDmg} on {barbName}.");
                System.Console.WriteLine($"{barbName} inflicts {barbDmg} on {fighterName}.");
                if (fighterHealth <= 0 ) {
                        System.Console.WriteLine($"{barbName} scores the killing blow to {fighterName}!");
                        while (barbarianHealth > 0 && fighterHealth <= 0){
                            System.Console.WriteLine($"{legionName} attacks suddenly, doing {legionDmg} to {barbName}");
                            if (barbarianHealth >= 0) {
                                Console.WriteLine($"{barbName} inflicts {barbDmg} on {legionName}.");
                            }
                            else{System.Console.WriteLine($"{legionName} has killed {barbName}!");
                                gameOver = true;
                            };
                        }
                }
                else if( barbarianHealth <= 0 ) {
                        System.Console.WriteLine($"{fighterName} scores the killing blow to {barbName}!");
                        gameOver = true;
                }
            }

        }
    }
}
