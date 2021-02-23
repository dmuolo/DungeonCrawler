using GameLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon0 = new Weapon("Jump", 1, 1, "A plain old jump.", true);
            Weapon weapon1 = new Weapon("Hammer", 1, 1, "A plain old hammer.", false);
            Weapon marioWeapon = new Weapon("No attack equipped", 0, 0, "N/A", false);
            Mario mario = new Mario("Mario", 10, 10, 50, 10, marioWeapon);
            bool exit = false;

            int enemiesDefeated = 0;

            #region Region 1
            do
            {
                Enemy goomba = new Enemy("Goomba", 2, 2, 10, 0, "Small fry.", 1, 1, false, false);
                Enemy paragoomba = new Enemy("Paragoomba", 2, 2, 10, 0, "A goomba with wings.", 1, 1, false, true);
                Enemy spikyGoomba = new Enemy("Spiky Goomba", 2, 2, 10, 0, "A goomba witha  spike on its head.", 2, 2, true, false);
                Enemy koopa = new Enemy("Koopa", 4, 4, 15, 10, "A koopa troopa. They're Bowser's followers.", 2, 2, false, false);
                Enemy paratroopa = new Enemy("Paratroopa", 4, 4, 15, 10, "A flying koopa troopa! They're Bowser's followers.", 2, 2, false, true);

                Enemy[] enemies =
                {
                    goomba, paragoomba, spikyGoomba, koopa, paratroopa
                };
                Enemy enemy = enemies[new Random().Next(enemies.Length)];

                Console.WriteLine($"You encountered a {enemy.Name}!\n");
                Console.CursorVisible = false;

                bool exit1 = false;

                do
                {
                    Console.WriteLine();
                    Console.Write("Choose an action:\n" +
                        "J)ump\n" +
                        "H)ammer\n" +
                        "I)tem\n" +
                        "F)lee\n" +
                        "Esc) Leave Game");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen
                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            marioWeapon = weapon0;
                            if (enemy.IsSpiked == true)
                            {
                                mario.Life--;
                                Console.WriteLine("You jumped on a spiked enemy! Mario lost 1 HP.");
                                Console.Read();
                                Console.Clear();
                            }
                            else
                            {
                                Combat.DoBattle(mario, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou killed {enemy.Name}!");
                                    enemiesDefeated++;
                                    Console.Read();
                                    Console.Clear();
                                }
                            }
                            break;

                        case ConsoleKey.H:
                            marioWeapon = weapon1;
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine("Hammer is ineffective on flying enemies. You missed!");
                                Console.Read();
                                Console.Clear();
                            }
                            else
                            {
                                Combat.DoBattle(mario, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou killed {enemy.Name}!");
                                    enemiesDefeated++;
                                    Console.Read();
                                    Console.Clear();
                                }
                            }
                            break;

                        case ConsoleKey.I:
                            Combat.DoBattle(mario, enemy);
                            if (enemy.Life <= 0)
                            {
                                Console.WriteLine($"\nYou killed {enemy.Name}!");
                                enemiesDefeated++;
                                Console.Read();
                                Console.Clear();
                            }
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine("FLEE!");
                            Console.WriteLine($"{enemy.Name} attacks you as you flee!");
                            Combat.DoAttack(enemy, mario);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You escaped!");
                            exit = true;
                            break;
                    }
                    if (mario.Life <= 0)
                    {
                        Console.WriteLine("Mario has died.");
                        exit = true;
                    }


                } while (!exit1 && !exit && enemiesDefeated < 5);
            } while (!exit);

            #endregion

            /*
             * PAPER MARIO GAME
             * You fight Bowser, but you lose no matter what.
             * You then go into 4 major loops. Each is a section of the game.
             * Optional: Within each world, you can choose to exit and go to town to purchase usable items using coins you receive from defeating enemies.
             * Within these loops, you basically have to kill a predetermined # of randomized enemies and then you gain access to the boss. The game is structured so that, if you die in one of these world loops, you can just start over from the beginning of that loop to continue.
             *  
             *  COMBAT
             Combat consists of you choosing an action (jump or hammer), then your partner choosing an action (specific to each partner). Then the enemy attacks. Look into doing timed attacks, if not, just do straight probability. There is a menu for Mario's attack where he can also use items (which are ocassionally dropped by normal enemies) in place of an attack.
             If extra time: There is an XP system where, once you kill a certain amount of enemy value, you reach a new level. Here, you can select to upgrade your jump or your hammer. There can also be coins yielded after battles and an option to fight another enemy or go to town. When you go to town, you can use your coins to buy mushrooms and special attack items.
             Music
             Hidden Content
             Etc.
             */

            Console.WindowWidth = 131;
            Console.Title = String.Format("{0, " + 144 + "}", "A Paper Mario Adventure");

            #region Title Screen
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine(String.Format("{0, " + 100 + "}", "─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  "));

            Console.Beep(622, 500);

            Console.WriteLine(String.Format("{0, " + 100 + "}", "▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░"));

            System.Threading.Thread.Sleep(40);
            Console.Beep(554, 480);

            Console.WriteLine(String.Format("{0, " + 100 + "}", "█▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██"));

            System.Threading.Thread.Sleep(40);
            Console.Beep(740, 455);

            Console.WriteLine(String.Format("{0, " + 100 + "}", "└▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███"));

            System.Threading.Thread.Sleep(40);
            Console.Beep(659, 415);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(String.Format("{0, " + 100 + "}", "██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀"));
            System.Threading.Thread.Sleep(40);
            Console.Beep(831, 350);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            System.Threading.Thread.Sleep(40);
            Console.Beep(740, 500);

            Console.WriteLine("######                                  #####  ######     #     #####  #######                                                     #     # #####  ######  ####   ####     #     # #     #   # #   #     # #          #####  ####      ####  #####   ##   #####  ##### #     # #    # #      #      #         #       #     #  #   #  #       #            #   #    #    #        #    #  #  #    #   #   ######  #    # #####   ####   ####      #####  ######  #     # #       #####        #   #    #     ####    #   #    # #    #   #   #       #####  #           #      #          # #       ####### #       #            #   #    #         #   #   ###### #####    #   #       #   #  #      #    # #    #    #     # #       #     # #     # #            #   #    #    #    #   #   #    # #   #    #   #       #    # ######  ####   ####      #####  #       #     #  #####  #######      #    ####      ####    #   #    # #    #   #   ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(String.Format("{0, " + 100 + "}", "─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  "));
            Console.WriteLine(String.Format("{0, " + 100 + "}", "▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░"));
            Console.WriteLine(String.Format("{0, " + 100 + "}", "█▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██"));
            Console.WriteLine(String.Format("{0, " + 100 + "}", "└▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███"));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(String.Format("{0, " + 100 + "}", "██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀"));
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(40);
            Console.Beep(988, 1100);

            System.Threading.Thread.Sleep(1000);
            Console.CursorVisible = true;
            bool startGame = true;


            do
            {
                ConsoleKey space = Console.ReadKey(true).Key;
                switch (space)
                {
                    case ConsoleKey.Spacebar:
                        Console.Clear();
                        startGame = false;
                        break;
                    default:

                        break;
                }

            } while (startGame);
            #endregion

            #region At Mario's House
            Console.CursorVisible = false;

            System.Threading.Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;

            //#region Test
            //Console.Beep(250, 1100);
            //Random textBeepEffect = new Random();
            //int beeps = textBeepEffect.Next(37, 1000);
            //Console.Beep(beeps, 500);
            //System.Threading.Thread.Sleep(2000);
            //Console.Beep(beeps, 500);
            //#endregion

            string intro1 = String.Format("{0, " + 72 + "}", "Mail call!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro1)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(100);
            }

            System.Threading.Thread.Sleep(300);
            Console.Beep(100, 300);
            System.Threading.Thread.Sleep(100);
            Console.Beep(100, 300);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string intro2 = String.Format("{0, " + 87 + "}", "Hey, Mario!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro2)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }
            string intro3 = String.Format("{0, " + 100 + "}", "We got a letter from Princess Peach!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro3)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }
            System.Threading.Thread.Sleep(1700);
            Console.Clear();
            Console.Beep(198, 300); Console.Beep(200, 300); Console.Beep(202, 300);
            string intro4 = String.Format("{0, " + 80 + "}", "I'll read it to you, okay?");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro4)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.Beep(500, 120);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            string intro5 = String.Format("{0, " + 85 + "}", "I'm throwing a party at my castle today!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro5)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            string intro6 = String.Format("{0, " + 95 + "}", "Mario and Luigi, I would be honored if you both could attend.");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro6)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            string intro7 = String.Format("{0, " + 80 + "}", "I hope to see you here soon!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro7)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            string intro8 = String.Format("{0, " + 70 + "}", "Sincerely,");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro8)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            string intro9 = String.Format("{0, " + 85 + "}", "Princess Peach             ");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro9)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.CursorVisible = true;

            startGame = true;
            do
            {
                ConsoleKey space = Console.ReadKey(true).Key;
                switch (space)
                {
                    case ConsoleKey.Spacebar:
                        Console.Beep(100, 100);
                        Console.Clear();
                        Console.CursorVisible = false;
                        startGame = false;
                        break;
                    default:

                        break;
                }

            } while (startGame);
            #endregion

            #region At the Castle
            System.Threading.Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.CursorVisible = true;
            string intro10 = String.Format("{0, " + 80 + "}", "Later, at the castle...");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro10)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(12);
            }
            Console.CursorVisible = false;

            Console.Beep(165, 250);
            Console.Beep(196, 250);
            Console.Beep(262, 250);
            Console.Beep(330, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(262, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(262, 250);
            Console.Beep(245, 700);
            System.Threading.Thread.Sleep(100);
            Console.Beep(220, 250);
            System.Threading.Thread.Sleep(1000);

            Console.Beep(196, 250);
            Console.Beep(245, 250);
            Console.Beep(294, 250);
            Console.Beep(349, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(330, 250);
            System.Threading.Thread.Sleep(250);
            Console.Beep(294, 250);
            Console.Beep(330, 250);
            Console.Beep(262, 250);
            Console.Beep(196, 250);
            Console.Beep(175, 500);
            Console.Beep(165, 250);

            System.Threading.Thread.Sleep(1000);

            #endregion

            //Play twink's theme while you talk to princess peach (multi-threading?)
            //Oh, Mario! You came to the party to see me!



        }//end Main()
    }//end class
}//end namespace
