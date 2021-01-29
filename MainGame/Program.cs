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
            /*
             * PAPER MARIO GAME
             * The game starts with some kind of menu/music, press space or whatever
             * There's some dialogue. You speak to a character who joins you in your quest.
             * You go to a party and Bowser has kidnapped Princess Peach. You fight Bowser, but you lose no matter what.
             * You wake up and realize it's time to fight Bowser again. You fight goombas, paragoombas, koopas until you get a certain amount of upgrades which prompts the option to go fight with Boss 1.
             * If you beat boss 1, you have some more dialogue and meet another character who joins your party. More dialogue, now you go to fight some more to level up to fight boss 2. Once you reach a certain level, you have the option to fight Boss 2.
             *  * If you beat boss 2, you have some more dialogue and meet another character who joins your party. More dialogue, now you go to fight some more to level up to fight boss 3. Once you reach a certain level, you have the option to fight Boss 3.
             *  Once you beat Boss 3, you now get a rematch with Bowser!
             *  If you die at any point along the way, you have to start the whole game over!
             *  
             *  COMBAT
             Combat consists of you choosing an action (jump or hammer), then your partner choosing an action (specific to each partner). Then the enemy attacks. Look into doing timed attacks, if not, just do straight probability. There is a menu for Mario's attack where he can also use items (which are ocassionally dropped by normal enemies) in place of an attack. There is an XP system where, once you kill a certain amount of enemy value, you reach a new level. Here, you can select to upgrade your jump or your hammer.
             There will also be ASCII art and so on for the battles.
             If extra time: There can also be coins yielded after battles and an option to fight another enemy or go to town. When you go to town, you can use your coins to buy mushrooms and special attack items.
             Music
             Hidden Content
             Etc.
             */
            Console.WindowWidth = 131;
            Console.Title = String.Format("{0, " + 144 + "}", "A Paper Mario Adventure");

            Console.CursorVisible = false;
            Console.Beep(37, 500);

            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine(String.Format("{0, " + 100 + "}", "─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  ─▄████▄▄░  "));

                Console.Beep(650, 500);

                Console.WriteLine(String.Format("{0, " + 100 + "}", "▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░"));

                System.Threading.Thread.Sleep(40);
                Console.Beep(580, 480);

                Console.WriteLine(String.Format("{0, " + 100 + "}", "█▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██ █▄▐▌▄█▄┘██"));

                System.Threading.Thread.Sleep(40);
                Console.Beep(750, 460);

                Console.WriteLine(String.Format("{0, " + 100 + "}", "└▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███ └▄▄▄▄▄┘███"));

                System.Threading.Thread.Sleep(40);
                Console.Beep(650, 440);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(String.Format("{0, " + 100 + "}", "██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀  ██▒█▒███▀"));
                System.Threading.Thread.Sleep(40);
                Console.Beep(850, 420);

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                System.Threading.Thread.Sleep(40);
                Console.Beep(750, 550);

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
                Console.Beep(1000, 1100);

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
            Console.CursorVisible = false;

            System.Threading.Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;

            string intro1 = String.Format("{0, " + 72 + "}", "Mail call!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro1)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(60);
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
            System.Threading.Thread.Sleep(800);
            Console.Clear();
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
            System.Threading.Thread.Sleep(2000);
            Console.CursorVisible = true;

            startGame = true;

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

            System.Threading.Thread.Sleep(1000);

        }//end Main()
    }//end class
}//end namespace
