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
            System.Threading.Thread.Sleep(500);
            if (diceRoll <= attacker.CalcHitChance() - defender.CalcBlock())//ex. dice roll is 80. Attacker Calc hit chance is 70. Defender calc block is 10. Would need to roll a 60 or below.
            {
                //The attacker hit!
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;
                if (attacker.Name == "Mario")
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.CursorLeft = Console.BufferWidth - 100;
                    string attack = $"Mario hit {defender.Name} for " +
                        $"{damageDealt} damage!";
                    foreach (char c in attack)
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(20);
                    }
                    System.Threading.Thread.Sleep(300);
                    Console.ResetColor();
                }
                else
                {
                    Console.Beep(65, 100);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string attack = $"{attacker.Name} hit Mario for " +
                        $"{damageDealt} damage!";
                    int length = attacker.Name.Length;
                    Console.CursorLeft = Console.BufferWidth - (length + 25);
                    foreach (char c in attack)
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(20);
                    }
                    System.Threading.Thread.Sleep(300);
                    Console.ResetColor();
                }
            }
            else
            {
                if (attacker.Name == "Mario")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Threading.Thread.Sleep(300);

                    Console.CursorLeft = Console.BufferWidth - 90;
                    Console.Write("Mario missed!");

                    System.Threading.Thread.Sleep(500);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Threading.Thread.Sleep(300);

                    int length = attacker.Name.Length;
                    Console.CursorLeft = Console.BufferWidth - (length + 15);
                    Console.Write($"{attacker.Name} missed!");

                    System.Threading.Thread.Sleep(500);
                    Console.ResetColor();
                }
            }
        }// end DoAttack()

        public static void DoBattle(Mario mario, Enemy enemy)
        {
            DoAttack(mario, enemy);
            if (enemy.Life > 0)
            {
                DoAttack(enemy, mario);
                System.Threading.Thread.Sleep(700);
            }
        }

        //initiative system initiative property in character class
    }
}
