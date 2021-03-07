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


            Console.WindowWidth = 131;
            Console.Title = String.Format("{0, " + 144 + "}", "A Paper Mario Adventure");
            Console.CursorVisible = false;

            #region Start Game

            #region Title Screen
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(300);
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

            System.Threading.Thread.Sleep(2000);

            #endregion

            Console.Clear();
            Console.ResetColor();
            Console.Beep(41, 1500);

            Console.Beep(82, 166);
            Console.Beep(98, 166);
            Console.Beep(116, 167);
            Console.Beep(139, 1000);

            Console.Beep(116, 500);
            Console.Beep(139, 500);
            Console.Beep(98, 500);
            Console.Beep(116, 1250);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;

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

            #endregion

            #region Region 1
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string region1Intro = "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` R O U N D ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` O N E ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ";


            foreach (char c in region1Intro)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            Weapon weapon0 = new Weapon("Jump", 1, 1, "A plain old jump.", true);
            Weapon weapon1 = new Weapon("Hammer", 1, 1, "A plain old hammer.", false);
            Weapon marioWeapon = new Weapon("No attack equipped", 0, 0, "N/A", false);
            Mario mario = new Mario("Mario", 10, 10, 50, 5, marioWeapon);

            int enemiesDefeated = 0;
            bool region1 = true;

            do
            {
                Enemy goomba = new Enemy("Goomba", 2, 2, 30, 0, "Small fry. No problemo!", 1, 1, false, false, false);
                Enemy paragoomba = new Enemy("Paragoomba", 2, 2, 30, 0, "A goomba with wings. Easy!", 1, 1, false, true, false);
                Enemy spikyGoomba = new Enemy("Spiky Goomba", 2, 2, 30, 0, "A goomba with a spike on its head.", 2, 2, true, false, false);
                Enemy koopa = new Enemy("Koopa", 4, 4, 35, 10, "A koopa troopa. They're Bowser's followers.", 2, 2, false, false, false);//1 defense
                Enemy paratroopa = new Enemy("Paratroopa", 4, 4, 40, 10, "A flying koopa troopa! They're Bowser's followers.", 2, 2, false, true, false);//1 defense

                Enemy[] enemies =
                {
                    koopa, goomba, paragoomba, spikyGoomba, paratroopa
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
                    Console.Write($"{enemy.Name}'s");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" HP: {enemy.Life} / {enemy.MaxLife} ");
                    Console.WriteLine();
                    Console.CursorVisible = false;

                    if (enemy.Name == "Goomba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//1
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@  ////  @ @@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@//@@ / @ / @@@@@@@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@ //,@@.,#@@///@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&//,@////////,.// @@@@@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ///////////////@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ,,  &&&&&&#@@@@@@@@@@@@@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@ %%% *.&&&&& ** @@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@, %*.@@@.*****%@@@@@@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    }
                    else if (enemy.Name == "Paragoomba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&.@@");//1
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@ @@@. & ,,  %      ,,,  @#  @@@@@ ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@  @@@@@  .,.#### .,      @@@@@@@  ");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@ @@@@@@@ # / * .@@ ### @@@@@@@@@@ ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("& @@@@@@//@@@@#.@@@@@ ## @@@@@@@@@ ");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@ .&&& #%@%  #*  @@@@##((@@@@&&&  ");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@ (  #########(/## (((#    *@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@# # @@#/     ,/*@@@(((( ,@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@  // #########((.,//  *@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@ %%%# /.%%%%%%%//,##%%( @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@ %&&%%/ .%%##%.%%%&&&  @@@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@    @@@@@@@(     *@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    }
                    else if (enemy.Name == "Spiky Goomba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//1
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@ @@ @@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@ @@&@ @@@@@@@@@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@    ((((/// ,, @@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ,.. @@@@....   @@@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@* &@@        @@&&% @@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@( (@@  (  @@@ ((  @@@@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@ (.@@@ ( @@@@.(((  @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@  (@ (((((((((( @(//( @@@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@ (  ((((((((# @@(// @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@    (((/((#     @@@@@@@@@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@ **** %#%### ****** @@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@        ,  # .****/ @@@@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//18
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
                        Console.Write("@@@@@@@@@@@@@ #% @@@/@ @@@@@(@ @@@@");//12
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
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
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
                        Console.Write("@@@@@@@/,####%####/(/,,/%%,%@@@@@@@");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@&./@&,##(,.@@@@@@@@@@@@@@");
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

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" J) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Jump\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" H) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Hammer\n");
                    /*
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Item\n");
                    */
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" T) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Tattle\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" F) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Flee\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" Esc) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Quit Game");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen


                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            marioWeapon = weapon0;
                            Console.Beep(100, 150);
                            Console.Beep(250, 150);
                            if (enemy.IsSpiked == true)
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.Beep(60, 200);
                                mario.Life--;
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 100;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string spiked = " You jumped on a spiked enemy! Mario lost 1 HP. ";
                                foreach (char c in spiked)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else if (enemy.IsFire == true)
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.Beep(60, 200);
                                mario.Life--;
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 100;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string fire = " You jumped on a fire enemy! Mario lost 1 HP. ";
                                foreach (char c in fire)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Combat.DoBattle(mario, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    System.Threading.Thread.Sleep(1000);

                                    Console.Beep(233, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(196, 125);
                                    Console.Beep(175, 63);
                                    System.Threading.Thread.Sleep(25);

                                    Console.Beep(196, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(233, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(175, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(233, 50);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 68);
                                    foreach (char c in defeat)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(5);
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                    enemiesDefeated++;
                                    exitEncounter = true;
                                    Console.ResetColor();
                                }
                            }
                            break;

                        case ConsoleKey.H:
                            marioWeapon = weapon1;
                            Console.Beep(200, 500);
                            System.Threading.Thread.Sleep(400);
                            Console.Beep(70, 100);
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 105;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string air = " Hammer is ineffective on flying enemies. You missed! ";
                                foreach (char c in air)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Combat.DoBattle(mario, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    System.Threading.Thread.Sleep(1000);

                                    Console.Beep(233, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(196, 125);
                                    Console.Beep(175, 63);
                                    System.Threading.Thread.Sleep(25);

                                    Console.Beep(196, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(233, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(175, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(233, 50);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 68);
                                    foreach (char c in defeat)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(5);
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                    enemiesDefeated++;
                                    exitEncounter = true;
                                    Console.ResetColor();
                                }
                            }
                            break;
                        /*
                    case ConsoleKey.I:
                        Combat.DoBattle(mario, enemy);
                        Console.Clear();
                        if (enemy.Life <= 0)
                        {
                            Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                            enemiesDefeated++;
                        }
                        break;
                        */

                        case ConsoleKey.T:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            if (enemy.Name == "Goomba")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@  ////  @ @@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@//@@ / @ / @@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@ //,@@.,#@@///@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@&//,@////////,.// @@@@@@@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@ ///////////////@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@ ,,  &&&&&&#@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@ %%% *.&&&&& ** @@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@, %*.@@@.*****%@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                            }
                            else if (enemy.Name == "Paragoomba")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("| @@@. & ,,  %      ,,,  @#  @@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|  @@@@@  .,.#### .,      @@@@@@@ |");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("| @@@@@@@ # / * .@@ ### @@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("| @@@@@@//@@@@#.@@@@@ ## @@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@ .&&& #%@%  #*  @@@@##((@@@@&&& |");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@ (  #########(/## (((#    *@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@# # @@#/     ,/*@@@(((( ,@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@  // #########((.,//  *@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@ %%%# /.%%%%%%%//,##%%( @@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@ %&&%%/ .%%##%.%%%&&&  @@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@    @@@@@@@(     *@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                            }
                            else if (enemy.Name == "Spiky Goomba")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@ @@ @@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@ @@&@ @@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@    ((((/// ,, @@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@ ,.. @@@@....   @@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@* &@@        @@&&% @@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@( (@@  (  @@@ ((  @@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@ (.@@@ ( @@@@.(((  @@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@  (@ (((((((((( @(//( @@@@@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@ (  ((((((((# @@(// @@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@    (((/((#     @@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@ **** %#%### ****** @@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                            }
                            else if (enemy.Name == "Koopa")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@ @@@ @@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@ @@@ #% @@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@ @ @@@ %##@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@ %(#%*,#########.@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@############%#### @@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@ #####%###########@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@ ###% ##%###%%# #   .*   &@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@  @@@@@ %##  @@ ******** @@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@ @@@@  @@@**** ****,@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@ ###(  # @@***** ** @@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@%%##%##% @@@,***** @@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@ #% @@@/@ @@@@@(@ @@@|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@ .***   ( @@ ###  @( @@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@.@ % **** (@@ ## ****. @@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@ @@@ ** (@@@@  *****@ @@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@., .@@@@@@@***** @@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                            }
                            else
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@,@@#@@#,%,*@@@,@@@@/,@@@,@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@#,,@*.@,@&%/,%@@@@@.. ,@@@##,|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@.,%%&%%%%%@#%%%@@@@@@@,(@@@@@@,|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@,%%%%%%%%%%%%%%%@@@@@(@@@@@@@*,|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@.,%%%%%%&%%%%%%///%#@@@@@@@@@@,|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@,,%*%%%%%%%%@&///@@@@@@@@@%,@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@#.#((%#%%@&///*,,,,(@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@,,.%##%,%%%@%///,@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@,*///%(/((%%%%%@,//,@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@.,###(###//(%%%%@@&,@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@/,####%####/(/,,/%%,%@@@@@@|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@&./@&,##(,.@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                            }

                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            int nameLength = enemy.Name.Length;
                            int normalizedName = ((nameLength - 5) / (12));
                            Console.CursorLeft = Console.BufferWidth - (72 + normalizedName);
                            Console.WriteLine(" " + " " + enemy.Name + " " + " ");
                            Console.WriteLine();
                            Console.ResetColor();

                            int descriptionLength = enemy.Description.Length;
                            int normalized = ((descriptionLength - 10) / (32));
                            Console.CursorLeft = Console.BufferWidth - (80 + normalized);
                            Console.Write("\"" + $"{enemy.Description}" + "\"");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 68;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("HP: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.MaxLife}");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 72;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Attack Power: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.MaxDamage}");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 71;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Accuracy: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.HitChance}%");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 70;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Evasion: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.Block}%");

                            bool leaveStats = false;
                            do
                            {
                                ConsoleKey space = Console.ReadKey(true).Key;
                                switch (space)
                                {
                                    case ConsoleKey.Spacebar:
                                        leaveStats = true;
                                        break;
                                }

                            } while (!leaveStats);
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 95;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            string flee = $" { enemy.Name} attacks you as you flee! ";
                            foreach (char c in flee)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(20);
                            }
                            System.Threading.Thread.Sleep(500);
                            Console.ResetColor();
                            Combat.DoAttack(enemy, mario);
                            System.Threading.Thread.Sleep(3000);
                            exitEncounter = true;
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            string really = String.Format("{0, " + 69 + "}", ". . .");
                            foreach (char c in really)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(80);
                            }
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            string leave = String.Format("{0, " + 84 + "}", "Are you sure you want to leave?\n");
                            foreach (char c in leave)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(40);
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(String.Format("{0, " + 58 + "}", "Y) "));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Yes, I want to leave.\n");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(String.Format("{0, " + 56 + "}", "N) "));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("No! I want to keep playing!");
                            ConsoleKey exitChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen

                            switch (exitChoice)
                            {
                                case ConsoleKey.Y:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    string thanks = String.Format("{0, " + 84 + "}", "Thank you for playing my game!");
                                    foreach (char c in thanks)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(40);
                                    }
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Environment.Exit(0);
                                    break;
                                case ConsoleKey.N:
                                    break;
                            }
                            break;

                    }
                    if (mario.Life <= 0)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        string gameOver = String.Format("{0, " + 73 + "}", "GAME OVER\n");
                        foreach (char c in gameOver)
                        {
                            Console.Write(c);
                            System.Threading.Thread.Sleep(80);
                        }
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        string stats = String.Format("{0, " + 57 + "}", $"You completed");
                        Console.Write(stats);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" 0 ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("waves and defeated");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($" {enemiesDefeated} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (enemiesDefeated == 0 || enemiesDefeated >= 2)
                        {
                            Console.Write("enemies!");
                        }
                        else
                        {
                            Console.Write("enemy!");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        string leave = String.Format("{0, " + 82 + "}", "Would you like to try again?\n");
                        foreach (char c in leave)
                        {
                            Console.Write(c);
                            System.Threading.Thread.Sleep(40);
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(String.Format("{0, " + 63 + "}", "Y) "));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Count me in!\n");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(String.Format("{0, " + 56 + "}", "N) "));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("No, I think I've had enough.");

                        ConsoleKey exitChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen

                        switch (exitChoice)
                        {
                            case ConsoleKey.Y:
                                mario.Life = 10;
                                enemiesDefeated = 0;
                                Console.Clear();
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                string thanks = String.Format("{0, " + 84 + "}", "Thank you for playing my game!");
                                foreach (char c in thanks)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(40);
                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine();
                                Console.WriteLine();
                                Environment.Exit(0);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;

                    }

                    Console.Clear();

                } while (region1 && !exitEncounter);
            } while (region1 && enemiesDefeated < 7);

            #endregion

            #region LevelUp
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Blue;
            string levelUp = String.Format("{0, " + 62 + "}", "");
            foreach (char c in levelUp)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(5);
            }
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" LEVEL UP! ");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();

            string super = String.Format("{0, " + 71 + "}", "You acquired the ");
            foreach (char c in super)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("SUPER JUMP");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(",");
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0, " + 74 + "}", "SUPER HAMMER"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(",");
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.Write(String.Format("{0, " + 65 + "}", "and "));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("10 MORE HP!");
            System.Threading.Thread.Sleep(5000);
            Console.ResetColor();
            #endregion

            #region Region 2
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string region2Intro = "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` R O U N D ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` T W O ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ";


            foreach (char c in region2Intro)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            Weapon weapon2 = new Weapon("Super Jump", 3, 3, "Now that's a jump.", true);
            Weapon weapon3 = new Weapon("Super Hammer", 3, 3, "Now's that's a hammer.", false);
            Mario mario2 = new Mario("Mario", 20, 20, 65, 7, marioWeapon);

            int enemiesDefeated2 = 0;
            bool region2 = true;

            do
            {
                Enemy shyGuy = new Enemy("Shy Guy", 7, 7, 25, 0, "A little red guy causing a ruckus in the Toy Box.", 2, 2, false, false, false);
                Enemy pyroGuy = new Enemy("Pyro Guy", 7, 7, 25, 0, "A shy guy that's literally on fire!", 4, 4, false, false, true);
                Enemy skyGuy = new Enemy("Sky Guy", 7, 7, 20, 0, "A flying shy guy with a sling shot! Oh my!", 3, 3, false, true, false);
                Enemy clubba = new Enemy("Clubba", 8, 8, 30, 10, "An off-duty guard from Tubba Blubba's castle.", 3, 3, true, false, false);
                Enemy koopatrol = new Enemy("Koopatrol", 8, 8, 40, 15, "An elite koopa solider from Bowser's castle!", 4, 4, true, false, false);//1 defense

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
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//2
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@&&%(%%&&&@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@&&%//#&&@@@@@@");//4
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@&&&&&&&&&&#//(%&&@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@&&((/////((///(*((&&@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&&%///((///((//,,*((%&&@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&&(%&&&%*,,,,,,,*(///#&&@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&&#*,,,,,,,,((,,,,*#(/(/#&&@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@&&/*%&/,*&&&*,*%*,,,,,*(/#&&@@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&#&/%&&&*&&&&&,,*%,,,,*//(&&@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&&(/%/#&&%*#&&&#,,*%,,,,*(#%%%%&&");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&&(/%/,,,,,,,,,,,*%**(((#(#(/#&&&");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&&&&#(#(*,,&*,,,,((,//**/#*,*//(%&");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&(***##*,,%&&&%*,,,,*((****((*(/#&");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&#*,,,,,,,,,,,/(//(####/(%&&");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&##%&#**,,,,,,,*&&&&&&&&&&&@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&######%&&&%##&&########%&&@@@");//18
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
                        Console.Write("@@@@@@@@@@@@@@@&%#&&@&%%&&@@@@@@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    }
                    else if (enemy.Name == "Clubba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@&##&@@@@&@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@#(/,%(((#(&#@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&#&../(%*,&@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&##((##%##&@@@@&/..%(&@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&/##%%%(&#@@@&........,&@&@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&@&%%&@@%*////////%,,,,,&@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&%&%*(/&//////////.((&&@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@%*.**//////%////%..(###@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&#%/#%%(////%////(..#%%%&@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@(/(%&......%//////%.,&&&#@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@%#&&....(////(//////%&%(((/");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@%&&...*//#(..%////////(((%");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&%@&.......%/////((///(/%@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&/*%&&&((%&&###%%%#&&@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&%&@%(&/..,((/(((((%%&@@@@");
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&%%%%%%%%%///(((@@@@@@@");//18
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
                        Console.Write("@@@@@@@@@@@@@@@@&&&&&&&&&&/**&&@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//17
                    }

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" J) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Super Jump\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" H) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Super Hammer\n");
                    /*
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Item\n");
                    */
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" T) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Tattle\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" F) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Flee\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" Esc) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Quit Game");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen


                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            marioWeapon = weapon2;
                            Console.Beep(100, 150);
                            Console.Beep(250, 150);
                            if (enemy.IsSpiked == true)
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.Beep(60, 200);
                                mario2.Life--;
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 100;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string spiked = " You jumped on a spiked enemy! Mario lost 1 HP. ";
                                foreach (char c in spiked)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario2);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else if (enemy.IsFire == true)
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.Beep(60, 200);
                                mario2.Life--;
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 100;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string fire = " You jumped on a fire enemy! Mario lost 1 HP. ";
                                foreach (char c in fire)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario2);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Combat.DoBattle(mario2, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    System.Threading.Thread.Sleep(1000);

                                    Console.Beep(233, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(196, 125);
                                    Console.Beep(175, 63);
                                    System.Threading.Thread.Sleep(25);

                                    Console.Beep(196, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(233, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(175, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(233, 50);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 68);
                                    foreach (char c in defeat)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(5);
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                    enemiesDefeated2++;
                                    exitEncounter = true;
                                    Console.ResetColor();
                                }
                            }
                            break;

                        case ConsoleKey.H:
                            marioWeapon = weapon3;
                            Console.Beep(200, 500);
                            System.Threading.Thread.Sleep(400);
                            Console.Beep(70, 100);
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 105;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string air = " Hammer is ineffective on flying enemies. You missed! ";
                                foreach (char c in air)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario2);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Combat.DoBattle(mario2, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    System.Threading.Thread.Sleep(1000);

                                    Console.Beep(233, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(196, 125);
                                    Console.Beep(175, 63);
                                    System.Threading.Thread.Sleep(25);

                                    Console.Beep(196, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(233, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(175, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(233, 50);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 68);
                                    foreach (char c in defeat)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(5);
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                    enemiesDefeated2++;
                                    exitEncounter = true;
                                    Console.ResetColor();
                                }
                            }
                            break;
                        /*
                    case ConsoleKey.I:
                        Combat.DoBattle(mario, enemy);
                        Console.Clear();
                        if (enemy.Life <= 0)
                        {
                            Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                            enemiesDefeated++;
                        }
                        break;
                        */

                        case ConsoleKey.T:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            if (enemy.Name == "Shy Guy")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@,,,,,&&&@@@@@@&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@&,,,.,,,,,,*,,,,&@@@&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@*,/@@@@@@@,,,,,,,,..&@@@&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@,,&.,.@,...@#.*,,.,.&@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@,,@*.*@*..*@@.****@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@,,/@@@@@@@@@.,,,,,,@@@@@@&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@*,.%@.@@&*,,,,,,,,*&@@@@&|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@.*,,,,,**,,*,,,,,,.,&&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@&*,,,,,...,,,,,,,,,&@&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@.*,***.,,,,,******,,&&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                            }
                            else if (enemy.Name == "Pyro Guy")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//1
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//2
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@&&%(%%&&&@@@@@@|");//3
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@&&%//#&&@@@@@|");//4
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@&&&&&&&&&&#//(%&&@@@@|");//5
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@&&((/////((///(*((&&@@@@|");//6
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@&&%///((///((//,,*((%&&@@@|");//7
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@&&(%&&&%*,,,,,,,*(///#&&@@|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@&&#*,,,,,,,,((,,,,*#(/(/#&&@|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@&&/*%&/,*&&&*,*%*,,,,,*(/#&&@|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&#&/%&&&*&&&&&,,*%,,,,*//(&&@@|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@&&(/%/#&&%*#&&&#,,*%,,,,*(#%%%%&|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@&&(/%/,,,,,,,,,,,*%**(((#(#(/#&&|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&#(#(*,,&*,,,,((,//**/#*,*//(%|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&(***##*,,%&&&%*,,,,*((****((*(/#|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&#*,,,,,,,,,,,/(//(####/(%&|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&&##%&#**,,,,,,,*&&&&&&&&&&&@@|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }
                            else if (enemy.Name == "Sky Guy")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@&&&@@&,  ,******/&@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@&%#####%&/***********%%%%(((#%%&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&(  *###%&%*********&%#. ,((((((#|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|%#########&(*******/%#((#(((#((#(|");//5
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&###########&&%//%&&&%((((#(((((#|");//6
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@&%#######%&@@&//%&@@%#((((((((#%|");//7
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@&%#%&@@@&@@@@@@%%#%#%%&@@@|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@&&@@@@&@@@@@&&%%%%@@@@@@|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@&&@@&@@@&&@@@@@@@@@@@@|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@&&*,*&###&&@@@@@@@@@@@@@@|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&%/#./&/ %%#&##&&@@@@@@@@@@|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&#&&,%&% /(*/&&@@@@@@@@@@@@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&&@&&  #.  .&%##&%%&@@@@@@@@@@|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&/*%&&&((%&&###%%%#&&@@@@@@@@@|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@&#*%%&%#%&&&&##&&##%&#(&@@@@@@@@|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }
                            else if (enemy.Name == "Clubba")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@&##&@@@@&@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|#(/,%(((#(&#@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@&#&../(%*,&@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@&##((##%##&@@@@&/..%(&@@@@@@@@@@|");//5
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&/##%%%(&#@@@&........,&@&@@@@@|");//6
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&@&%%&@@%*////////%,,,,,&@@@@@|");//7
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&%&%*(/&//////////.((&&@@@@|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@%*.**//////%////%..(###@@@|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&#%/#%%(////%////(..#%%%&@@|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@(/(%&......%//////%.,&&&#@@|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@%#&&....(////(//////%&%(((|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@%&&...*//#(..%////////(((|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@&%@&.......%/////((///(/%|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&/*%&&&((%&&###%%%#&&@@@@@@@@@|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@&%&@%(&/..,((/(((((%%&@@@|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }
                            else
                            {//koopatrol
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@# *,%@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@&*/*&@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&&,,,,,#&@&@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@% .,**,,,,,,%#%@@@@@@@@@@@@@|");//5
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@**&.&&*/&,**,%##&@@@@@@@@@@@|");//6
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&****,(&&&&&&/(*&&&%@@@@@@@@@@@|");//7
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&# *@**,*****@,*#,@&&&&%@@@@@@@@@|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&. ***,****//@,%@/@&&&&@@@@@@@@@@|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@& ,***,**%%*,,**%@&&@&@@&&*,&@@@|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&***&#//(%**%@#/%##&..,,,&@@@@|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@&*,,,**,&/.*%%**/&//#&@|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@&/////,&**&.%%&&&&&@@@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&.,/(/&##%%@.,*/&.#&,..,&&@|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&/%*/&**#,,,,,,(&.%&*,*(%&&|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@&/*@..***&%,,.%@@@@@@|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }

                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            int nameLength = enemy.Name.Length;
                            int normalizedName = ((nameLength - 6) / (3));
                            Console.CursorLeft = Console.BufferWidth - (69 + normalizedName);
                            Console.WriteLine(" " + " " + enemy.Name + " " + " ");
                            Console.WriteLine();
                            Console.ResetColor();

                            int descriptionLength = enemy.Description.Length;
                            int normalized = ((descriptionLength - 35) / (14));
                            Console.CursorLeft = Console.BufferWidth - (84 + normalized);
                            Console.Write("\"" + $"{enemy.Description}" + "\"");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 68;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("HP: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.MaxLife}");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 72;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Attack Power: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.MaxDamage}");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 71;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Accuracy: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.HitChance}%");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 70;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Evasion: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.Block}%");

                            bool leaveStats = false;
                            do
                            {
                                ConsoleKey space = Console.ReadKey(true).Key;
                                switch (space)
                                {
                                    case ConsoleKey.Spacebar:
                                        leaveStats = true;
                                        break;
                                }

                            } while (!leaveStats);
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 95;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            string flee = $" { enemy.Name} attacks you as you flee! ";
                            foreach (char c in flee)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(20);
                            }
                            System.Threading.Thread.Sleep(500);
                            Console.ResetColor();
                            Combat.DoAttack(enemy, mario2);
                            System.Threading.Thread.Sleep(3000);
                            exitEncounter = true;
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            string really = String.Format("{0, " + 69 + "}", ". . .");
                            foreach (char c in really)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(80);
                            }
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            string leave = String.Format("{0, " + 84 + "}", "Are you sure you want to leave?\n");
                            foreach (char c in leave)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(40);
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(String.Format("{0, " + 58 + "}", "Y) "));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Yes, I want to leave.\n");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(String.Format("{0, " + 56 + "}", "N) "));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("No! I want to keep playing!");
                            ConsoleKey exitChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen

                            switch (exitChoice)
                            {
                                case ConsoleKey.Y:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    string thanks = String.Format("{0, " + 84 + "}", "Thank you for playing my game!");
                                    foreach (char c in thanks)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(40);
                                    }
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Environment.Exit(0);
                                    break;
                                case ConsoleKey.N:
                                    break;
                            }
                            break;

                    }
                    if (mario2.Life <= 0)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        string gameOver = String.Format("{0, " + 73 + "}", "GAME OVER\n");
                        foreach (char c in gameOver)
                        {
                            Console.Write(c);
                            System.Threading.Thread.Sleep(80);
                        }
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        string stats = String.Format("{0, " + 57 + "}", $"You completed");
                        Console.Write(stats);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" 1 ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("wave and defeated");
                        Console.ForegroundColor = ConsoleColor.White;
                        int scoreTotal = enemiesDefeated2 + 7;
                        Console.Write($" {scoreTotal} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (enemiesDefeated2 == 0 || enemiesDefeated2 >= 2)
                        {
                            Console.Write("enemies!");
                        }
                        else
                        {
                            Console.Write("enemy!");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        string leave = String.Format("{0, " + 82 + "}", "Would you like to try again?\n");
                        foreach (char c in leave)
                        {
                            Console.Write(c);
                            System.Threading.Thread.Sleep(40);
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(String.Format("{0, " + 63 + "}", "Y) "));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Count me in!\n");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(String.Format("{0, " + 56 + "}", "N) "));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("No, I think I've had enough.");

                        ConsoleKey exitChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen

                        switch (exitChoice)
                        {
                            case ConsoleKey.Y:
                                mario2.Life = 15;
                                enemiesDefeated2 = 0;
                                Console.Clear();
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                string thanks = String.Format("{0, " + 84 + "}", "Thank you for playing my game!");
                                foreach (char c in thanks)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(40);
                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine();
                                Console.WriteLine();
                                Environment.Exit(0);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;

                    }

                    Console.Clear();

                } while (region2 && !exitEncounter);
            } while (region2 && enemiesDefeated2 < 7);

            #endregion

            #region LevelUpAgain!

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Blue;
            string levelUp2 = String.Format("{0, " + 62 + "}", "");
            foreach (char c in levelUp2)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(5);
            }
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" LEVEL UP! ");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();

            string ultra = String.Format("{0, " + 71 + "}", "You acquired the ");
            foreach (char c in ultra)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ULTRA JUMP");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(",");
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0, " + 74 + "}", "ULTRA HAMMER"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(",");
            Console.WriteLine();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.Write(String.Format("{0, " + 65 + "}", "and "));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("10 MORE HP!");
            System.Threading.Thread.Sleep(5000);
            Console.ResetColor();

            #endregion

            #region Region 3
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string region3Intro = "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` R O U N D ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` T H R E E ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` " + "` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ` ";


            foreach (char c in region3Intro)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            Weapon weapon4 = new Weapon("Ultra Jump", 3, 5, "The best jump there is.", true);
            Weapon weapon5 = new Weapon("Ultra Hammer", 3, 5, "The best hammer out there.", false);
            Mario mario3 = new Mario("Mario", 30, 30, 75, 10, marioWeapon);

            int enemiesDefeated3 = 0;
            bool region3 = true;

            do
            {
                Enemy dryBones = new Enemy("Dry Bones", 8, 8, 35, 0, "A skeleton koopa that looks pretty creepy!", 4, 4, false, false, false);//2 defense
                Enemy koopatrol = new Enemy("Koopatrol", 8, 8, 40, 15, "An elite koopa solider with a spike on his helmet.", 4, 4, true, false, false);//1 defense
                Enemy magikoopa = new Enemy("Magikoopa", 11, 11, 40, 10, "A magician of the koopa clan. Lots of HP!", 3, 3, false, false, false);//could add heal function
                Enemy hammerBro = new Enemy("Hammer Bro", 12, 12, 40, 20, "This retro punk that wields a hefty hammer.", 5, 5, false, false, false);
                Enemy billBlaster = new Enemy("Bill Blaster", 4, 4, 30, 10, "A cannon that shoots out bullet bills.", 8, 8, false, false, false);//1 defense

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
                    Console.Write(" Wave 1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Enemies Defeated: {enemiesDefeated3} / 7");
                    Console.Write(" ------------------------ ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Mario's ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"HP: {mario3.Life} / {mario3.MaxLife} ");
                    Console.Write("------------------------------");
                    int numChars = (enemy.Name).Length;
                    Console.CursorLeft = Console.BufferWidth - (numChars + 14);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{enemy.Name}'s");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" HP: {enemy.Life} / {enemy.MaxLife} ");
                    Console.WriteLine();
                    Console.CursorVisible = false;

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
                        Console.Write("@@@@@@@@@@@@ %#(((%(((((((((((/ @@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@  @@@@,,,**,,%/%@ &@@@");//18
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
                        Console.Write("@@@@@@@@@@@@@*/&@@@//////((((@@@@@@");//18
                    }
                    else if (enemy.Name == "Magikoopa")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//1
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//2
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&&");//4
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&&&&&&&&(((((&&&&&&&&&&");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&&&&&&((((((((&&&&&&&&&");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&&&&((((((((((&&&&&&&&&");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&((((((((##(((((((&&&&&&&&");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&,/@#,,,&((((&(((#&&&&&&&&");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&#&/*@ ,,&%((((((&#&&&&&&&&");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&,,,,**,,,,,*%((#####%&&&&&&");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&,****,,,,,,,,,**&####(&&&&&&");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&***&,,,#*,,,*,#(((((%&&&&&&");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&//#%,*&&&&&&((((((((((((((#((&@@@@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&%/..%/%&%..((((((((#((((##%#(&&&&");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&%,(,&((((((%/####(*,*#%&&&");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&/,%&%#####%......../#%&%%");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&&&&&&(########&&&&&#%&###(&");//18
                    }
                    else if (enemy.Name == "Bill Blaster")
                    {
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//1
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//2
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//4
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@&    &@@@@@@@@@@@@@@@@@@@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@/%%%%(&&&@%*%%%%%%%%%%%%%%%%% @@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@%%  /%,%%%%%%%%%%%%%%%%%%%%%%%%,@@");//11
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write(" %    %%#####/#################%#@@");//12
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write(" %    %%#####/#######. .**  ,###%@@");//13
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@%%  (%,####%#### %%%%/////////(,@@");//14
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@.%%%%%%%%%%,## %&@%////.*//*(///.@");//15
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@     %###/ %%%%/////.* **///// ");//16
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@ ##/(###/////////////////");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@,%%%%%%%/////////////////");//18
                    }
                    else
                    {//koopatrol
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@&,&@@@@@@@@@@@@@@@@@");//1
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@# *,%@@@@@@@@@@@@@@@@");//2
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@&*/*&@@@@@@@@@@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&&,,,,,#&@&@@@@@@@@@@@@@@@@@");//4
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
                        Console.Write("@@@@@@@@@@@@@@@@&&&&&&&&&&/**&&@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//18
                    }

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" J) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ultra Jump\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" H) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ultra Hammer\n");
                    /*
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Item\n");
                    */
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" T) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Tattle\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" F) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Flee\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" Esc) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Quit Game");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen


                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            marioWeapon = weapon4;
                            Console.Beep(100, 150);
                            Console.Beep(250, 150);
                            if (enemy.IsSpiked == true)
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.Beep(60, 200);
                                mario3.Life--;
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 100;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string spiked = " You jumped on a spiked enemy! Mario lost 1 HP. ";
                                foreach (char c in spiked)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario3);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else if (enemy.IsFire == true)
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.Beep(60, 200);
                                mario3.Life--;
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 100;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string fire = " You jumped on a fire enemy! Mario lost 1 HP. ";
                                foreach (char c in fire)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario3);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Combat.DoBattle(mario3, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    System.Threading.Thread.Sleep(1000);

                                    Console.Beep(233, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(196, 125);
                                    Console.Beep(175, 63);
                                    System.Threading.Thread.Sleep(25);

                                    Console.Beep(196, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(233, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(175, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(233, 50);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 68);
                                    foreach (char c in defeat)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(5);
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                    enemiesDefeated3++;
                                    exitEncounter = true;
                                    Console.ResetColor();
                                }
                            }
                            break;

                        case ConsoleKey.H:
                            marioWeapon = weapon5;
                            Console.Beep(200, 500);
                            System.Threading.Thread.Sleep(400);
                            Console.Beep(70, 100);
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 105;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string air = " Hammer is ineffective on flying enemies. You missed! ";
                                foreach (char c in air)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(20);
                                }
                                System.Threading.Thread.Sleep(2000);
                                Console.ResetColor();
                                Combat.DoAttack(enemy, mario3);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Combat.DoBattle(mario3, enemy);
                                if (enemy.Life <= 0)
                                {
                                    //loot drops, leveling, etc. could happen here. Healing could happen here. Etc.
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    System.Threading.Thread.Sleep(1000);

                                    Console.Beep(233, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(196, 125);
                                    Console.Beep(175, 63);
                                    System.Threading.Thread.Sleep(25);

                                    Console.Beep(196, 125);
                                    Console.Beep(220, 125);
                                    Console.Beep(233, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(175, 50);
                                    System.Threading.Thread.Sleep(75);
                                    Console.Beep(233, 50);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 68);
                                    foreach (char c in defeat)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(5);
                                    }
                                    System.Threading.Thread.Sleep(2000);
                                    enemiesDefeated3++;
                                    exitEncounter = true;
                                    Console.ResetColor();
                                }
                            }
                            break;
                        /*
                    case ConsoleKey.I:
                        Combat.DoBattle(mario, enemy);
                        Console.Clear();
                        if (enemy.Life <= 0)
                        {
                            Console.WriteLine($"\nYou defeated the {enemy.Name}!");
                            enemiesDefeated++;
                        }
                        break;
                        */

                        case ConsoleKey.T:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            if (enemy.Name == "Dry Bones")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@............,(@@@@@@@@@@@|");//2
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@(*@@(..@@@@@..,,.@@@@@@@@@@|");//3
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@.@,.*.&@  @@@,,,,,@@@@@@@@@|");//4
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@,.../....@@@@@(,,,,.@@@@@@@@@|");//5
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@(..@./@...,,,,,,,,,,,,@@@@@@@@@@|");//6
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@.........,,,,,,,,,,,,&@@@@@@@@@@|");//7
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@,,.,,,,,,,,,.,,.,%@@,*@....@%@@@|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@/.@,,,,.,,,,@@.%@&,..@...@%(&..@|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@(#,,,.@@%..,/..(.|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@&...@@@@&@@,@@@@..,*,@@|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@.....@,.......@..#&,/..@@,*|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@,@.%&.........,@,,,@@@.,,&@@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@#*@.#.@..@@@@/.,,,*(,@,/@@|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@&#%@@@@@@@@@@@@|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@*/////%&///%(////@@@@|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@#/////(/////////((&@@@|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }
                            else if (enemy.Name == "Magikoopa")//
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&&&&&&&&&&&&(((((&&&&&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&&&&&&&&&&((((((((&&&&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&&&&&&&&((((((((((&&&&&&&&|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&&((((((((##(((((((&&&&&&&|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&&,/@#,,,&((((&(((#&&&&&&&|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&#&/*@ ,,&%((((((&#&&&&&&&|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&,,,,**,,,,,*%((#####%&&&&&|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&,****,,,,,,,,,**&####(&&&&&|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&***&,,,#*,,,*,#(((((%&&&&&|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|//#%,*&&&&&&((((((((((((((#((&@@@|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&%/..%/%&%..((((((((#((((##%#(&&&|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&%,(,&((((((%/####(*,*#%&&|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&&&&&&&&&/,%&%#####%......../#%&%|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }
                            else if (enemy.Name == "Bill Blaster")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//1
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//2
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//3
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//4
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//5
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//6
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//7
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@&    &@@@@@@@@@@@@@@@@@@@@@@@@|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|/%%%%(&&&@%*%%%%%%%%%%%%%%%%% @@@|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|%%  /%,%%%%%%%%%%%%%%%%%%%%%%%%,@|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|%    %%#####/#################%#@|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|%    %%#####/#######. .**  ,###%@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|%%  (%,####%#### %%%%/////////(,@|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|.%%%%%%%%%%,## %&@%////.*//*(///.|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@     %###/ %%%%/////.* **/////|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@ ##/(###////////////////|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }
                            else if (enemy.Name == "Hammer Bro")
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@@@  @*.....@#&@. ,@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@@ @...........&%(@  @@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@ ,,@..(/...&...,%@(& @@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@@ @&/@@@@,.@*&.*...@ @@@@@@|");//5
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@,.*,,,,,,,*****&..@.@ @@@@@@|");//6
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@ @,,,,,,,,,,,,,&@.@.@  @@@@@|");//7
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@, ,,,,,@/,,,,,@%%(#@(((/@  @|");//8
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@@  @% /%@%@%%,,,&#..@((.(@ |");//9
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@     @&%    %@,,*&*,&**(#/((/(@|");//10
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@ /#&*&&&%/  @,,,,,,,*&****%@(/((|");//11
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("| @&%@&/&@@***@,,,,,@(*#@***@/(((%|");//12
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|  @%&&&/@#*//*%%&/(*%*****@.#.(#(|");//13
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@,   , #*(*%@(&,@&******@..@@ @|");//14
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@@@@@@  @(((&@@@@#&@# @@@ @@|");//15
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@@@@@  #((((#((((((#(((@ @@@|");//16
                                Console.CursorLeft = Console.BufferWidth - 35;
                                Console.WriteLine("|@@@@@@@@@@@ %#(((%(((((((((((/ @@|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                            }
                            else
                            {
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@# *,%@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@&*/*&@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&&,,,,,#&@&@@@@@@@@@@@@@@@@|");
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@% .,**,,,,,,%#%@@@@@@@@@@@@@|");//5
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@**&.&&*/&,**,%##&@@@@@@@@@@@|");//6
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&****,(&&&&&&/(*&&&%@@@@@@@@@@@|");//7
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&# *@**,*****@,*#,@&&&&%@@@@@@@@@|");//8
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|&. ***,****//@,%@/@&&&&@@@@@@@@@@|");//9
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@& ,***,**%%*,,**%@&&@&@@&&*,&@@@|");//10
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@&&***&#//(%**%@#/%##&..,,,&@@@@|");//11
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@&*,,,**,&/.*%%**/&//#&@|");//12
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@&/////,&**&.%%&&&&&@@@|");//13
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&.,/(/&##%%@.,*/&.#&,..,&&@|");//14
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@&/%*/&**#,,,,,,(&.%&*,*(%&&|");//15
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@&/*@..***&%,,.%@@@@@@|");//16
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("|@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|");//17
                                Console.CursorLeft = Console.BufferWidth - 82;
                                Console.WriteLine("___________________________________");//18
                            }

                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            int nameLength = enemy.Name.Length;
                            int normalizedName = ((nameLength - 5) / (12));
                            Console.CursorLeft = Console.BufferWidth - (72 + normalizedName);
                            Console.WriteLine(" " + " " + enemy.Name + " " + " ");
                            Console.WriteLine();
                            Console.ResetColor();

                            int descriptionLength = enemy.Description.Length;
                            int normalized = ((descriptionLength - 10) / (32));
                            Console.CursorLeft = Console.BufferWidth - (80 + normalized);
                            Console.Write("\"" + $"{enemy.Description}" + "\"");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 68;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("HP: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.MaxLife}");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 72;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Attack Power: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.MaxDamage}");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 71;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Accuracy: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.HitChance}%");

                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 70;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Evasion: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{enemy.Block}%");

                            bool leaveStats = false;
                            do
                            {
                                ConsoleKey space = Console.ReadKey(true).Key;
                                switch (space)
                                {
                                    case ConsoleKey.Spacebar:
                                        leaveStats = true;
                                        break;
                                }

                            } while (!leaveStats);
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine();
                            Console.CursorLeft = Console.BufferWidth - 95;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            string flee = $" { enemy.Name} attacks you as you flee! ";
                            foreach (char c in flee)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(20);
                            }
                            System.Threading.Thread.Sleep(500);
                            Console.ResetColor();
                            Combat.DoAttack(enemy, mario3);
                            System.Threading.Thread.Sleep(3000);
                            exitEncounter = true;
                            break;

                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            string really = String.Format("{0, " + 69 + "}", ". . .");
                            foreach (char c in really)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(80);
                            }
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            string leave = String.Format("{0, " + 84 + "}", "Are you sure you want to leave?\n");
                            foreach (char c in leave)
                            {
                                Console.Write(c);
                                System.Threading.Thread.Sleep(40);
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(String.Format("{0, " + 58 + "}", "Y) "));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Yes, I want to leave.\n");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(String.Format("{0, " + 56 + "}", "N) "));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("No! I want to keep playing!");
                            ConsoleKey exitChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen

                            switch (exitChoice)
                            {
                                case ConsoleKey.Y:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    string thanks = String.Format("{0, " + 84 + "}", "Thank you for playing my game!");
                                    foreach (char c in thanks)
                                    {
                                        Console.Write(c);
                                        System.Threading.Thread.Sleep(40);
                                    }
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Environment.Exit(0);
                                    break;
                                case ConsoleKey.N:
                                    break;
                            }
                            break;

                    }
                    if (mario3.Life <= 0)
                    {
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        string gameOver = String.Format("{0, " + 73 + "}", "GAME OVER\n");
                        foreach (char c in gameOver)
                        {
                            Console.Write(c);
                            System.Threading.Thread.Sleep(80);
                        }
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        string stats = String.Format("{0, " + 57 + "}", $"You completed");
                        Console.Write(stats);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" 2 ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("waves and defeated");
                        Console.ForegroundColor = ConsoleColor.White;
                        int scoreTotal2 = enemiesDefeated3 + 14;
                        Console.Write($" {scoreTotal2} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (enemiesDefeated3 == 0 || enemiesDefeated3 >= 2)
                        {
                            Console.Write("enemies!");
                        }
                        else
                        {
                            Console.Write("enemy!");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        string leave = String.Format("{0, " + 82 + "}", "Would you like to try again?\n");
                        foreach (char c in leave)
                        {
                            Console.Write(c);
                            System.Threading.Thread.Sleep(40);
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(String.Format("{0, " + 63 + "}", "Y) "));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Count me in!\n");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(String.Format("{0, " + 56 + "}", "N) "));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("No, I think I've had enough.");

                        ConsoleKey exitChoice = Console.ReadKey().Key;//.ReadKey method, .Key property; If you put true in, it stops the key from showing to the screen

                        switch (exitChoice)
                        {
                            case ConsoleKey.Y:
                                mario3.Life = 10;
                                enemiesDefeated3 = 0;
                                Console.Clear();
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                string thanks = String.Format("{0, " + 84 + "}", "Thank you for playing my game!");
                                foreach (char c in thanks)
                                {
                                    Console.Write(c);
                                    System.Threading.Thread.Sleep(40);
                                }
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine();
                                Console.WriteLine();
                                Environment.Exit(0);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;

                    }

                    Console.Clear();

                } while (region3 && !exitEncounter);
            } while (region3 && enemiesDefeated3 < 7);

            #endregion

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

        }//end Main()
    }//end class
}//end namespace
