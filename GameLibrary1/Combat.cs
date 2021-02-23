using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(50);
            if (diceRoll <= attacker.CalcHitChance() - defender.CalcBlock())//ex. dice roll is 80. Attacker Calc hit chance is 70. Defender calc block is 10. Would need to roll a 60 or below.
            {
                //The attacker hit!
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\n{attacker.Name} hit {defender.Name} for " +
                    $"{damageDealt} damage!");
                Console.ResetColor();
                Console.Read();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\n\n{attacker.Name} missed!");
                Console.Read();
                Console.Clear();
            }
        }// end DoAttack()

        public static void DoBattle(Mario mario, Enemy enemy)
        {
            DoAttack(mario, enemy);
            if (enemy.Life > 0)
            {
                DoAttack(enemy, mario);
            }
        }

        //initiative system initiative property in character class
    }
}
