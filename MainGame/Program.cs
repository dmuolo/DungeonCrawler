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
            #region Start Game
            Console.WindowWidth = 131;
            Console.Title = String.Format("{0, " + 144 + "}", "A Paper Mario Adventure");
            Console.CursorVisible = false;
            /*

            #region Title Screen
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
            
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Beep(41, 1500);

            Console.Beep(82, 166);
            Console.Beep(98, 166);
            Console.Beep(116, 167);
            Console.Beep(139, 1000);

            Console.Beep(116, 500);
            Console.Beep(139, 500);
            Console.Beep(98, 500);
            Console.Beep(116, 1250);

            System.Threading.Thread.Sleep(100);

    

            Console.WriteLine();
            Console.WriteLine();
            string intro11 = String.Format("{0, " + 90 + "}", "MWAHAH. I, Bowser, have kidnapped Princess Peach!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro11)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();
            string intro12 = String.Format("{0, " + 95 + "}", "You'll have to defeat three hoards of baddies to get to me!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro12)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine();
            string intro13 = String.Format("{0, " + 93 + "}", "Only then will you be able to rescue Princess Peach...");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in intro13)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(3000);

            Console.Clear();
            
            string intro14 = "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` R O U N D ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` O N E ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` `" + " ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` `";

            
            foreach (char c in intro14)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            */

            #endregion
            Weapon weapon0 = new Weapon("Jump", 1, 1, "A plain old jump.", true);
            Weapon weapon1 = new Weapon("Hammer", 1, 1, "A plain old hammer.", false);
            Weapon marioWeapon = new Weapon("No attack equipped", 0, 0, "N/A", false);
            Mario mario = new Mario("Mario", 10, 10, 50, 10, marioWeapon);

            int enemiesDefeated = 0;
            bool region1 = true;

            #region Region 1
            do
            {
                Enemy goomba = new Enemy("Goomba", 2, 2, 20, 0, "Small fry.", 1, 1, false, false, false);
                Enemy paragoomba = new Enemy("Paragoomba", 2, 2, 20, 0, "A goomba with wings.", 1, 1, false, true, false);
                Enemy spikyGoomba = new Enemy("Spiky Goomba", 2, 2, 20, 0, "A goomba with a spike on its head.", 2, 2, true, false, false);
                Enemy koopa = new Enemy("Koopa", 4, 4, 30, 10, "A koopa troopa. They're Bowser's followers.", 2, 2, false, false, false);//1 defense
                Enemy paratroopa = new Enemy("Paratroopa", 4, 4, 30, 10, "A flying koopa troopa! They're Bowser's followers.", 2, 2, false, true, false);//1 defense

                Enemy[] enemies =
                {
                    spikyGoomba, koopa, paratroopa, goomba, paragoomba,
                };
                Enemy enemy = enemies[new Random().Next(enemies.Length)];

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                string encounterIntro = String.Format("{0, " + 70 + "}", "You encountered a... ");
                foreach (char c in encounterIntro)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }
                System.Threading.Thread.Sleep(200);
                string whitespace = String.Format("{0, " + 5 + "}", "");
                foreach (char c in whitespace)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                string enemyName = String.Format($"{enemy.Name}!").ToUpper();
                foreach (char c in enemyName)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }

                bool resumeFight = false;
                do
                {
                    ConsoleKey space = Console.ReadKey(true).Key;
                    switch (space)
                    {
                        case ConsoleKey.Spacebar:
                            Console.Clear();
                            resumeFight = true;
                            break;
                    }

                } while (!resumeFight);

                Console.Clear();
                Console.ResetColor();

                bool exitEncounter = false;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Wave 1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Enemies Defeated: {enemiesDefeated} / 7");
                    Console.Write(" ------------------------ ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Mario's ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"HP: {mario.Life} / {mario.MaxLife} ");
                    Console.Write("------------------------------");
                    int numChars = (enemy.Name).Length;
                    Console.CursorLeft = Console.BufferWidth - (numChars + 13);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{enemy.Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"'s HP: {enemy.Life} / {enemy.MaxLife} ");
                    Console.WriteLine();
                    Console.CursorVisible = false;
                    Console.WriteLine();

                    if (enemy.Name == "Goomba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@  ////  @ @@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@//@@ / @ / @@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@ //,@@.,#@@///@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&//,@////////,.// @@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ///////////////@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ,,  &&&&&&#@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@ %%% *.&&&&& ** @@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@, %*.@@@.*****%@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    }
                    else if (enemy.Name == "Paragoomba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&.@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@ @@@. & ,,  %      ,,,  @#  @@@@@ ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@  @@@@@  .,.#### .,      @@@@@@@  ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@ @@@@@@@ # / * .@@ ### @@@@@@@@@@ ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("& @@@@@@//@@@@#.@@@@@ ## @@@@@@@@@ ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@ .&&& #%@%  #*  @@@@##((@@@@&&&  ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@ (  #########(/## (((#    *@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@# # @@#/     ,/*@@@(((( ,@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@  // #########((.,//  *@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@ %%%# /.%%%%%%%//,##%%( @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@ %&&%%/ .%%##%.%%%&&&  @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@    @@@@@@@(     *@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    }
                    else if (enemy.Name == "Spiky Goomba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@ @@ @@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@ @@&@ @@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@    ((((/// ,, @@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ,.. @@@@....   @@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@* &@@        @@&&% @@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@( (@@  (  @@@ ((  @@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@ (.@@@ ( @@@@.(((  @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@  (@ (((((((((( @(//( @@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@ (  ((((((((# @@(// @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@    (((/((#     @@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@ **** %#%### ****** @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@        ,  # .****/ @@@@@@@");
                    }
                    else if (enemy.Name == "Koopa")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@ @@@ @@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@ @@@ #% @@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@ @ @@@ %##@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@ %(#%*,#########.@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@############%#### @@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@ #####%###########@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@ ###% ##%###%%# #   .*   &@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@  @@@@@ %##  @@ ******** @@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@ @@@@  @@@**** ****,@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@ ###(  # @@***** ** @@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@%%##%##% @@@,***** @@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@ #% @@@/@ @@@@@(@ @@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@ .***   ( @@ ###  @( @@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@.@ % **** (@@ ## ****. @@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ @@@ ** (@@@@  *****@ @@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@., .@@@@@@@***** @@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@      @@@@@");
                    }
                    else
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@,,@@@@@(, ,,@@@@@@,,@,@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@,@@#@@#,%,*@@@,@@@@/,@@@,@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@#,,@*.@,@&%/,%@@@@@.. ,@@@##,@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@.,%%&%%%%%@#%%%@@@@@@@,(@@@@@@,(");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@,%%%%%%%%%%%%%%%@@@@@(@@@@@@@*,@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@.,%%%%%%&%%%%%%///%#@@@@@@@@@@,(");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@,,%*%%%%%%%%@&///@@@@@@@@@%,@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@#.#((%#%%@&///*,,,,(@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@,,.%##%,%%%@%///,@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@,*///%(/((%%%%%@,//,@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@.,###(###//(%%%%@@&,@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@/,####%####/(/,,/%%,%@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@&./@&,##(,.@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&@#@&@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    }

                    string chooseAction = ("Choose an action: \n");
                    foreach (char c in chooseAction)
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(5);
                    }

                    Console.WriteLine();
                    Console.WriteLine("J) Jump\nH) Hammer\nI)Item\nT) Tattle\nF) Flee\nEsc) Quit Game");

                    ConsoleKey userChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen


                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            Console.Clear();
                            marioWeapon = weapon0;
                            if (enemy.IsSpiked == true)
                            {
                                mario.Life--;
                                Console.WriteLine("You jumped on a spiked enemy! Mario lost 1 HP.");
                            }
                            else if (enemy.IsFire == true)
                            {
                                mario.Life--;
                                Console.WriteLine("You jumped on a fire enemy! Mario lost 1 HP.");
                            }
                            else
                            {
                                Combat.DoBattle(mario, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                    enemiesDefeated++;
                                    exitEncounter = true;
                                    Console.Read();
                                }
                            }
                            break;

                        case ConsoleKey.H:
                            Console.Clear();
                            marioWeapon = weapon1;
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine("Hammer is ineffective on flying enemies. You missed!");
                                Console.Read();
                            }
                            else
                            {
                                Combat.DoBattle(mario, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                    enemiesDefeated++;
                                    exitEncounter = true;
                                    Console.Read();
                                }
                            }
                            break;

                        case ConsoleKey.I:
                            Console.Clear();
                            Combat.DoBattle(mario, enemy);
                            if (enemy.Life <= 0)
                            {
                                Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                enemiesDefeated++;
                                Console.Read();
                            }
                            break;

                        case ConsoleKey.T:
                            Console.Clear();
                            Console.WriteLine(enemy);
                            bool leaveStats = false;
                            do
                            {
                                ConsoleKey space = Console.ReadKey(true).Key;
                                switch (space)
                                {
                                    case ConsoleKey.Spacebar:
                                        Console.Clear();
                                        leaveStats = true;
                                        break;
                                }

                            } while (!leaveStats);
                            break;

                        case ConsoleKey.F:
                            Console.Clear();
                            Console.WriteLine("FLEE!");
                            Console.WriteLine($"{enemy.Name} attacks you as you flee!");
                            Combat.DoAttack(enemy, mario);
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine("You escaped!");
                            exitEncounter = true;
                            break;
                    }
                    if (mario.Life <= 0)
                    {
                        Console.WriteLine("Mario has died.");
                        region1 = true;
                    }


                } while (region1 && !exitEncounter);
            } while (region1 && enemiesDefeated < 7);

            #endregion

            #region Bye

            Weapon weapon2 = new Weapon("Super Jump", 2, 2, "Now that's a jump.", true);
            Weapon weapon3 = new Weapon("Super Hammer", 2, 2, "Now's that's a hammer.", false);
            Mario mario2 = new Mario("Mario", 15, 15, 65, 10, marioWeapon);

            int enemiesDefeated2 = 0;
            bool region2 = true;

            #region Region 2
            do
            {
                Enemy shyGuy = new Enemy("Shy Guy", 7, 7, 25, 0, "A little red guy causing a ruckus in the Toy Box.", 2, 2, false, false, false);
                Enemy pyroGuy = new Enemy("Pyro Guy", 7, 7, 25, 0, "A shy guy that's on fire!", 4, 4, false, false, true);
                Enemy skyGuy = new Enemy("Sky Guy", 7, 7, 20, 0, "A flying shy guy.", 3, 3, false, true, false);
                Enemy clubba = new Enemy("Clubba", 8, 8, 30, 10, "An off-duty guard from Tubba Blubba's castle. He holds a sharp club that sits just above his head.", 3, 3, true, false, false);
                Enemy koopatrol = new Enemy("Koopatrol", 8, 8, 35, 15, "An elite koopa solider with a spike on his helmet.", 4, 4, true, false, false);//1 defense

                Enemy[] enemies =
                {
                                skyGuy, clubba, koopatrol, shyGuy, pyroGuy
                            };
                Enemy enemy = enemies[new Random().Next(enemies.Length)];

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                string encounterIntro = String.Format("{0, " + 70 + "}", "You encountered a... ");
                foreach (char c in encounterIntro)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }
                System.Threading.Thread.Sleep(200);
                string whitespace = String.Format("{0, " + 5 + "}", "");
                foreach (char c in whitespace)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                string enemyName = String.Format($"{enemy.Name}!").ToUpper();
                foreach (char c in enemyName)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }

                bool resumeFight = false;
                do
                {
                    ConsoleKey space = Console.ReadKey(true).Key;
                    switch (space)
                    {
                        case ConsoleKey.Spacebar:
                            Console.Clear();
                            resumeFight = true;
                            break;
                    }

                } while (!resumeFight);

                Console.Clear();
                Console.ResetColor();

                bool exitEncounter = false;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Wave 2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Enemies Defeated: {enemiesDefeated2} / 7");
                    Console.Write(" ------------------------ ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Mario's ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"HP: {mario2.Life} / {mario2.MaxLife} ");
                    Console.Write("------------------------------");
                    int numChars = (enemy.Name).Length;
                    Console.CursorLeft = Console.BufferWidth - (numChars + 13);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{enemy.Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"'s HP: {enemy.Life} / {enemy.MaxLife} ");
                    Console.WriteLine();
                    Console.CursorVisible = false;
                    Console.WriteLine();

                    if (enemy.Name == "Shy Guy")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@,,,,,&&&@@@@@@&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@&,,,.,,,,,,*,,,,&@@@&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@*,/@@@@@@@,,,,,,,,..&@@@&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@,,&.,.@,...@#.*,,.,.&@@@@@&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@,,@*.*@*..*@@.****@@@@@@@@&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@,,/@@@@@@@@@.,,,,,,@@@@@@&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@*,.%@.@@&*,,,,,,,,*&@@@@&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@.*,,,,,**,,*,,,,,,.,&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&*,,,,,...,,,,,,,,,&@&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@.*,***.,,,,,******,,&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@&@@&@&&&&&&&&&&&&&&&&&&&&&&&&&&");
                    }
                    else if (enemy.Name == "Pyro Guy")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@&&&&@@@@@@@@@@@@");//1
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@&&%(%%&&&@@@@@@@");//2
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@&&%//#&&@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@&&&&&&&&&&#//(%&&@@@@@");//4
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@&&((/////((///(*((&&@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&&%///((///((//,,*((%&&@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&&(%&&&%*,,,,,,,*(///#&&@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&&#*,,,,,,,,((,,,,*#(/(/#&&@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@&&/*%&/,*&&&*,*%*,,,,,*(/#&&@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&#&/%&&&*&&&&&,,*%,,,,*//(&&@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&&(/%/#&&%*#&&&#,,*%,,,,*(#%%%%&&");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&&(/%/,,,,,,,,,,,*%**(((#(#(/#&&&");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&&&&#(#(*,,&*,,,,((,//**/#*,*//(%&");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&(***##*,,%&&&%*,,,,*((****((*(/#&");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&#*,,,,,,,,,,,/(//(####/(%&&");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&##%&#**,,,,,,,*&&&&&&&&&&&@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&######%&&&%##&&########%&&@@@");//17
                    }
                    else if (enemy.Name == "Sky Guy")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&&(*****%&&@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&&&@@&,  ,******/&@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&%#####%&/***********%%%%(((#%%&@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&(  *###%&%*********&%#. ,((((((#%");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&%#########&(*******/%#((#(((#((#(%");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&###########&&%//%&&&%((((#(((((#%");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&%#######%&@@&//%&@@%#((((((((#%&");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&%#%&@@@&@@@@@@%%#%#%%&@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@&&@@@@&@@@@@&&%%%%@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&&@@&@@@&&@@@@@@@@@@@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&&*,*&###&&@@@@@@@@@@@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&%/#./&/ %%#&##&&@@@@@@@@@@@");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&#&&,%&% /(*/&&@@@@@@@@@@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&@&&  #.  .&%##&%%&@@@@@@@@@@@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&/*%&&&((%&&###%%%#&&@@@@@@@@@@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&#*%%&%#%&&&&##&&##%&#(&@@@@@@@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@&%#&&@&%%&&@@@@@@@@@");//16
                    }
                    else if (enemy.Name == "Clubba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@&##&@@@@&@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@#(/,%(((#(&#@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&#&../(%*,&@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&##((##%##&@@@@&/..%(&@@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&/##%%%(&#@@@&........,&@&@@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&@&%%&@@%*////////%,,,,,&@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&%&%*(/&//////////.((&&@@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@%*.**//////%////%..(###@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&#%/#%%(////%////(..#%%%&@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@(/(%&......%//////%.,&&&#@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@%#&&....(////(//////%&%(((/");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@%&&...*//#(..%////////(((%");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&%@&.......%/////((///(/%@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&/*%&&&((%&&###%%%#&&@@@@@@@@@@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&%&@%(&/..,((/(((((%%&@@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&%%%%%%%%%///(((@@@@@@@");//16
                    }
                    else
                    {//koopatrol
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@&,&@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@# *,%@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@&*/*&@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&&,,,,,#&@&@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@% .,**,,,,,,%#%@@@@@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@**&.&&*/&,**,%##&@@@@@@@@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&****,(&&&&&&/(*&&&%@@@@@@@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&# *@**,*****@,*#,@&&&&%@@@@@@@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&. ***,****//@,%@/@&&&&@@@@@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@& ,***,**%%*,,**%@&&@&@@&&*,&@@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&***&#//(%**%@#/%##&..,,,&@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@&*,,,**,&/.*%%**/&//#&@@");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&/////,&**&.%%&&&&&@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&.,/(/&##%%@.,*/&.#&,..,&&@@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&/%*/&**#,,,,,,(&.%&*,*(%&&@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@&/*@..***&%,,.%@@@@@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@&&&&&&&&&&/**&&@@@@");//16
                    }

                    string chooseAction = ("Choose an action: \n");
                    foreach (char c in chooseAction)
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(5);
                    }

                    Console.WriteLine();
                    Console.WriteLine("J) Jump\nH) Hammer\nI)Item\nT) Tattle\nF) Flee\nEsc) Quit Game");

                    ConsoleKey userChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen


                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            Console.Clear();
                            marioWeapon = weapon2;
                            if (enemy.IsSpiked == true)
                            {
                                mario2.Life--;
                                Console.WriteLine("You jumped on a spiked enemy! Mario lost 1 HP.");
                            }
                            else if (enemy.IsFire == true)
                            {
                                mario2.Life--;
                                Console.WriteLine("You jumped on a fire enemy! Mario lost 1 HP.");
                            }
                            else
                            {
                                Combat.DoBattle(mario2, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                    enemiesDefeated2++;
                                    exitEncounter = true;
                                    Console.Read();
                                }
                            }
                            break;

                        case ConsoleKey.H:
                            Console.Clear();
                            marioWeapon = weapon3;
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine("Hammer is ineffective on flying enemies. You missed!");
                                Console.Read();
                            }
                            else
                            {
                                Combat.DoBattle(mario2, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                    enemiesDefeated2++;
                                    exitEncounter = true;
                                    Console.Read();
                                }
                            }
                            break;

                        case ConsoleKey.I:
                            Console.Clear();
                            Combat.DoBattle(mario2, enemy);
                            if (enemy.Life <= 0)
                            {
                                Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                enemiesDefeated2++;
                                Console.Read();
                            }
                            break;

                        case ConsoleKey.T:
                            Console.Clear();
                            Console.WriteLine(enemy);
                            bool leaveStats = false;
                            do
                            {
                                ConsoleKey space = Console.ReadKey(true).Key;
                                switch (space)
                                {
                                    case ConsoleKey.Spacebar:
                                        Console.Clear();
                                        leaveStats = true;
                                        break;
                                }

                            } while (!leaveStats);
                            break;

                        case ConsoleKey.F:
                            Console.Clear();
                            Console.WriteLine("FLEE!");
                            Console.WriteLine($"{enemy.Name} attacks you as you flee!");
                            Combat.DoAttack(enemy, mario2);
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine("You escaped!");
                            exitEncounter = true;
                            break;
                    }
                    if (mario2.Life <= 0)
                    {
                        Console.WriteLine("Mario has died.");
                        region2 = true;
                    }


                } while (region2 && !exitEncounter);
            } while (region2 && enemiesDefeated2 < 7);

            Weapon weapon4 = new Weapon("Ultra Jump", 2, 2, "The best jump there is.", true);
            Weapon weapon5 = new Weapon("Ultra Hammer", 2, 2, "The best hammer out there.", false);
            Mario mario3 = new Mario("Mario", 20, 20, 75, 20, marioWeapon);

            int enemiesDefeated3 = 0;
            bool region3 = true;

            #region Region 3
            do
            {
                Enemy dryBones = new Enemy("Dry Bones", 8, 8, 20, 0, "A skeleton koopa.", 4, 4, false, false, false);//2 defense
                Enemy koopatrol = new Enemy("Koopatrol", 8, 8, 25, 10, "An elite koopa solider with a spike on his helmet.", 4, 4, true, false, false);//1 defense
                Enemy magikoopa = new Enemy("Magikoopa", 11, 11, 25, 0, "A magician of the koopa clan.", 3, 3, false, true, false);//could add heal function
                Enemy hammerBro = new Enemy("Hammer Bro", 12, 12, 25, 25, "This punk wields a hefty hammer.", 5, 5, false, false, false);
                Enemy billBlaster = new Enemy("Bill Blaster", 4, 4, 25, 0, "A cannon that shoots out bullet bills.", 8, 8, false, false, false);//1 defense

                Enemy[] enemies =
                {
                                dryBones, koopatrol, magikoopa, hammerBro, billBlaster
                            };
                Enemy enemy = enemies[new Random().Next(enemies.Length)];

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                string encounterIntro = String.Format("{0, " + 70 + "}", "You encountered a... ");
                foreach (char c in encounterIntro)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }
                System.Threading.Thread.Sleep(200);
                string whitespace = String.Format("{0, " + 5 + "}", "");
                foreach (char c in whitespace)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                string enemyName = String.Format($"{enemy.Name}!").ToUpper();
                foreach (char c in enemyName)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(25);
                }

                bool resumeFight = false;
                do
                {
                    ConsoleKey space = Console.ReadKey(true).Key;
                    switch (space)
                    {
                        case ConsoleKey.Spacebar:
                            Console.Clear();
                            resumeFight = true;
                            break;
                    }

                } while (!resumeFight);

                Console.Clear();
                Console.ResetColor();

                bool exitEncounter = false;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Wave 2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Enemies Defeated: {enemiesDefeated2} / 7");
                    Console.Write(" ------------------------ ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Mario's ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"HP: {mario2.Life} / {mario2.MaxLife} ");
                    Console.Write("------------------------------");
                    int numChars = (enemy.Name).Length;
                    Console.CursorLeft = Console.BufferWidth - (numChars + 13);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{enemy.Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"'s HP: {enemy.Life} / {enemy.MaxLife} ");
                    Console.WriteLine();
                    Console.CursorVisible = false;
                    Console.WriteLine();

                    if (enemy.Name == "Hammer Bro")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@  @*.....@#&@. ,@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@ @...........&%(@  @@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@ ,,@..(/...&...,%@(& @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@ @&/@@@@,.@*&.*...@ @@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@,.*,,,,,,,*****&..@.@ @@@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@ @,,,,,,,,,,,,,&@.@.@  @@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@, ,,,,,@/,,,,,@%%(#@(((/@  @@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@  @% /%@%@%%,,,&#..@((.(@ %");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@     @&%    %@,,*&*,&**(#/((/(@ ");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@ /#&*&&&%/  @,,,,,,,*&****%@(/((,");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@ @&%@&/&@@***@,,,,,@(*#@***@/(((% ");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@  @%&&&/@#*//*%%&/(*%*****@.#.(#( ");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@,   , #*(*%@(&,@&******@..@@ @@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@  @(((&@@@@#&@# @@@ @@@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@  #((((#((((((#(((@ @@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@ %#(((%(((((((((((/ @@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@  @@@@,,,**,,%/%@ &@@@");//16
                    }
                    else if (enemy.Name == "Dry Bones")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@%.....,@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@............,(@@@@@@@@@@@@");//2
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@(*@@(..@@@@@..,,.@@@@@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@.@,.*.&@  @@@,,,,,@@@@@@@@@@");//4
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@,.../....@@@@@(,,,,.@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@(..@./@...,,,,,,,,,,,,@@@@@@@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@.........,,,,,,,,,,,,&@@@@@@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@,,.,,,,,,,,,.,,.,%@@,*@....@%@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@/.@,,,,.,,,,@@.%@&,..@...@%(&..@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@(#,,,.@@%..,/..(.@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@&...@@@@&@@,@@@@..,*,@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@.....@,.......@..#&,/..@@,*@");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@,@.%&.........,@,,,@@@.,,&@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@#*@.#.@..@@@@/.,,,*(,@,/@@@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@&#%@@@@@@@@@@@@@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@*/////%&///%(////@@@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@#/////(/////////((&@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@*/&@@@//////((((@@@@@@");//17
                    }
                    else if (enemy.Name == "Magikoopa")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&&&&&&&&(((((&&&&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&&&&&&((((((((&&&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&&&&((((((((((&&&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&((((((((##(((((((&&&&&&&&");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&,/@#,,,&((((&(((#&&&&&&&&");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&#&/*@ ,,&%((((((&#&&&&&&&&");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&,,,,**,,,,,*%((#####%&&&&&&");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&,****,,,,,,,,,**&####(&&&&&&");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&***&,,,#*,,,*,#(((((%&&&&&&");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&//#%,*&&&&&&((((((((((((((#((&@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&%/..%/%&%..((((((((#((((##%#(&&&&");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&%,(,&((((((%/####(*,*#%&&&");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&/,%&%#####%......../#%&%%");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&(########&&&&&#%&###(&");//15
                    }
                    else if (enemy.Name == "Bill Blaster")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@&    &@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@/%%%%(&&&@%*%%%%%%%%%%%%%%%%% @@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@%%  /%,%%%%%%%%%%%%%%%%%%%%%%%%,@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write(" %    %%#####/#################%#@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write(" %    %%#####/#######. .**  ,###%@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@%%  (%,####%#### %%%%/////////(,@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@.%%%%%%%%%%,## %&@%////.*//*(///.@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@     %###/ %%%%/////.* **///// ");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ##/(###/////////////////");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@,%%%%%%%/////////////////");//10
                    }
                    else
                    {//koopatrol
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@&,&@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@# *,%@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@&*/*&@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&&,,,,,#&@&@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@% .,**,,,,,,%#%@@@@@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@**&.&&*/&,**,%##&@@@@@@@@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&****,(&&&&&&/(*&&&%@@@@@@@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&# *@**,*****@,*#,@&&&&%@@@@@@@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&. ***,****//@,%@/@&&&&@@@@@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@& ,***,**%%*,,**%@&&@&@@&&*,&@@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&***&#//(%**%@#/%##&..,,,&@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@&*,,,**,&/.*%%**/&//#&@@");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&/////,&**&.%%&&&&&@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&.,/(/&##%%@.,*/&.#&,..,&&@@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&/%*/&**#,,,,,,(&.%&*,*(%&&@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@&/*@..***&%,,.%@@@@@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@&&&&&&&&&&/**&&@@@@");//16
                    }

                    string chooseAction = ("Choose an action: \n");
                    foreach (char c in chooseAction)
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(5);
                    }

                    Console.WriteLine();
                    Console.WriteLine("J) Jump\nH) Hammer\nI)Item\nT) Tattle\nF) Flee\nEsc) Quit Game");

                    ConsoleKey userChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen


                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            Console.Clear();
                            marioWeapon = weapon4;
                            if (enemy.IsSpiked == true)
                            {
                                mario3.Life--;
                                Console.WriteLine("You jumped on a spiked enemy! Mario lost 1 HP.");
                            }
                            else if (enemy.IsFire == true)
                            {
                                mario3.Life--;
                                Console.WriteLine("You jumped on a fire enemy! Mario lost 1 HP.");
                            }
                            else
                            {
                                Combat.DoBattle(mario3, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                    enemiesDefeated3++;
                                    exitEncounter = true;
                                    Console.Read();
                                }
                            }
                            break;

                        case ConsoleKey.H:
                            Console.Clear();
                            marioWeapon = weapon5;
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine("Hammer is ineffective on flying enemies. You missed!");
                                Console.Read();
                            }
                            else
                            {
                                Combat.DoBattle(mario3, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                    enemiesDefeated3++;
                                    exitEncounter = true;
                                    Console.Read();
                                }
                            }
                            break;

                        case ConsoleKey.I:
                            Console.Clear();
                            Combat.DoBattle(mario3, enemy);
                            if (enemy.Life <= 0)
                            {
                                Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                                enemiesDefeated3++;
                                Console.Read();
                            }
                            break;

                        case ConsoleKey.T:
                            Console.Clear();
                            Console.WriteLine(enemy);
                            bool leaveStats = false;
                            do
                            {
                                ConsoleKey space = Console.ReadKey(true).Key;
                                switch (space)
                                {
                                    case ConsoleKey.Spacebar:
                                        Console.Clear();
                                        leaveStats = true;
                                        break;
                                }

                            } while (!leaveStats);
                            break;

                        case ConsoleKey.F:
                            Console.Clear();
                            Console.WriteLine("FLEE!");
                            Console.WriteLine($"{enemy.Name} attacks you as you flee!");
                            Combat.DoAttack(enemy, mario3);
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine("You escaped!");
                            exitEncounter = true;
                            break;
                    }
                    if (mario3.Life <= 0)
                    {
                        Console.WriteLine("Mario has died.");
                        region2 = true;
                    }


                } while (region3 && !exitEncounter);
            } while (region3 && enemiesDefeated3 < 7);

            #region Bowser
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@*////#@@@@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@,,@(@@#.,/#/@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@....%/@ ((@@((%(((@@@#,@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@.............,,.  @(.,*.@.,*@@@@@@");//5
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@.,.....#.%/..,,   @(@@(((@*,@@@@@");//6
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@(@(.@..@#/@//&  @(,,*,(@@@@@");//7
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@..,....,,@/%@&(## (((((#(*.@@");//8
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@#@,,,@@&%**/*@(((@,,,,,@@@");//9
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@* *///@@***/@@@@(   @##@@#@,@@@");//10
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@./@@/@*.(//(% @**@....   @@@@@");//11
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@@@@@ *,*@(/******#@@,&/,@@");//12
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@@@#%**//@./******/*//***/@");//13
            Console.CursorLeft = Console.BufferWidth - 35;
            Console.Write("@@@@@@@@@@@@@@@@@ @.@/////((@@@@@@@");//14
            #endregion

            #endregion
            #endregion
            #endregion
        }//end Main()
    }//end class
}//end namespace
