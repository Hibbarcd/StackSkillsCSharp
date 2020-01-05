using System;

namespace stringsAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCharacter = "Klaytor the Mighty ";
            string spellName = "fireball";
            int damageTaken = 100;
            string damageReport = "the hero, " + nameOfCharacter + "has taken " + damageTaken + " damage from " + spellName;
            string damageReportV2 = string.Format("The hero {0} has taken {1} damage from {2}", nameOfCharacter,damageTaken,spellName);
            System.Console.WriteLine(damageReport);
            System.Console.WriteLine(damageReportV2);
            //below concat has variable order changed
            string damageReportV3 = string.Format("The hero {2} has taken {0} damage from {1}", nameOfCharacter,damageTaken,spellName);
            System.Console.WriteLine(damageReportV3);
            string damageReportV4 = $"the hero, {nameOfCharacter} took {damageTaken} damage from {spellName} and {nameOfCharacter} has died";
            System.Console.WriteLine(damageReportV4);
        }
    }
}
