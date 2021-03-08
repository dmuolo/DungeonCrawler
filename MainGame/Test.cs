using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary1;

namespace MainGame
{
    public class Test
    {
        static void Main(string[] args)
        {
            #region Settings

            Console.WindowWidth = 131;
            Console.Title = String.Format("{0, " + 144 + "}", "A Paper Mario Adventure");
            Console.CursorVisible = false;

            #endregion

            Weapon marioWeapon = new Weapon("No attack equipped", 0, 0, "N/A", false);

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

            Weapon weapon2 = new Weapon("Super Jump", 1, 3, "Now that's a jump.", true);
            Weapon weapon3 = new Weapon("Super Hammer", 1, 3, "Now's that's a hammer.", false);
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Mario's ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"HP: {mario2.Life} / {mario2.MaxLife} ");
                    Console.Write("------------------------------");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Wave 2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Enemies Defeated: {enemiesDefeated2} / 7");
                    Console.Write(" ------------------------ ");
                    int numChars = (enemy.Name).Length;
                    Console.CursorLeft = Console.BufferWidth - (numChars + 13);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{enemy.Name}'s");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" HP: {enemy.Life} / {enemy.MaxLife} ");
                    Console.WriteLine();
                    Console.CursorVisible = false;

                    if (enemy.Name == "Shy Guy")
                    {
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@@@@@@*..,***..@@@@@@@@@");//1 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@&@.,//***.&&&@/.@@@@@@@");//2 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@&@.****/***@*&&**.&@@@@@@");//3 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@&@@@./*****,***/*/*/****/. @");//4 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@./**/*/...,....&&%%(... /@@&");//5 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&.,.%&#.**,%&%%%.%%%**(,.%@@@@");//6 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&/,%%%*&**.&&* &&%&&%%%%%%.@@@");//7 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@..%%#%%%%&%.,,,*,&%%%%&..@@@");//8 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@,,,,,&&&@@@@@@&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@#@@*,..%%%&.*,,,,,,.&@@@@@@");//9 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@&,,,.,,,,,,*,,,,&@@@&&&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@..,****/****,..#@@@@@@@@@@@@");//10 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@*,/@@@@@@@,,,,,,,,..&@@@&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@%@..&&*.*.***/***.***(@@.&&%.#.@@");//11 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@,,&.,.@,...@#.*,,.,.&@@@@@&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@&,%&&&&&&&&.*.**&%%****&,&&(%#%,@@");//12 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@,,@*.*@*..*@@.****@@@@@@@@&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@#@.&*&,&&%#.,***,,.****. &&.%&&#@@");//13 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@,,/@@@@@@@@@.,,,,,,@@@@@@&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@&,(&&&&&&(.***********,&.&&&%,&&@");//14 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@*,.%@.@@&*,,,,,,,,*&@@@@&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@%&@#*.**/*,.******,./**,.&@&%@@@");//15 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@.*,,,,,**,,*,,,,,,.,&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@&@.*/*///*/.@./////*///*.&@@@@@");//16 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&*,,,,,...,,,,,,,,,&@&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@#@.*////*/*,&@*.**////,.@&@@@@@");//17 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@.*,***.,,,,,******,,&&&&&&&");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@#@##..,.,@(@%%&&&@&&@&&@@@@@@@");//18 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@&@@&@&&&&&&&&&&&&&&&&&&&&&&&&&&");
                    }
                    else if (enemy.Name == "Pyro Guy")
                    {
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@@@@@@*..,***..@@@@@@@@@");//1 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@&&&&@@@@@@@@@@@@");//1
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@&@.,//***.&&&@/.@@@@@@@");//2 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//2
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@&@.****/***@*&&**.&@@@@@@");//3 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@&&%(%%&&&@@@@@@@");//3
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@&@@@./*****,***/*/*/****/. @");//4 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@&&%//#&&@@@@@@");//4
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@./**/*/...,....&&%%(... /@@&");//5 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@&&&&&&&&&&#//(%&&@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&.,.%&#.**,%&%%%.%%%**(,.%@@@@");//6 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@&&((/////((///(*((&&@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&/,%%%*&**.&&* &&%&&%%%%%%.@@@");//7 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&&%///((///((//,,*((%&&@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@..%%#%%%%&%.,,,*,&%%%%&..@@@");//8 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&&(%&&&%*,,,,,,,*(///#&&@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@#@@*,..%%%&.*,,,,,,.&@@@@@@");//9 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&&#*,,,,,,,,((,,,,*#(/(/#&&@@");//9
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@..,****/****,..#@@@@@@@@@@@@");//10 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@&&/*%&/,*&&&*,*%*,,,,,*(/#&&@@");//10
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@%@..&&*.*.***/***.***(@@.&&%.#.@@");//11 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&#&/%&&&*&&&&&,,*%,,,,*//(&&@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@&,%&&&&&&&&.*.**&%%****&,&&(%#%,@@");//12 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&&(/%/#&&%*#&&&#,,*%,,,,*(#%%%%&&");//12
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@#@.&*&,&&%#.,***,,.****. &&.%&&#@@");//13 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&&(/%/,,,,,,,,,,,*%**(((#(#(/#&&&");//13
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@&,(&&&&&&(.***********,&.&&&%,&&@");//14 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&&&&#(#(*,,&*,,,,((,//**/#*,*//(%&");//14
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@%&@#*.**/*,.******,./**,.&@&%@@@");//15 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&(***##*,,%&&&%*,,,,*((****((*(/#&");//15
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@&@.*/*///*/.@./////*///*.&@@@@@");//16 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&&&&&&&&#*,,,,,,,,,,,/(//(####/(%&&");//16
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@#@.*////*/*,&@*.**////,.@&@@@@@");//17 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&##%&#**,,,,,,,*&&&&&&&&&&&@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@#@##..,.,@(@%%&&&@&&@&&@@@@@@@");//18 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&######%&&&%##&&########%&&@@@");//18
                    }
                    else if (enemy.Name == "Sky Guy")
                    {
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@@@@@@*..,***..@@@@@@@@@");//1 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&&(*****%&&@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@&@.,//***.&&&@/.@@@@@@@");//2 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&&&@@&,  ,******/&@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@&@.****/***@*&&**.&@@@@@@");//3 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&%#####%&/***********%%%%(((#%%&@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@&@@@./*****,***/*/*/****/. @");//4 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&(  *###%&%*********&%#. ,((((((#%");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@./**/*/...,....&&%%(... /@@&");//5 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("&%#########&(*******/%#((#(((#((#(%");//5
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&.,.%&#.**,%&%%%.%%%**(,.%@@@@");//6 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&###########&&%//%&&&%((((#(((((#%");//6
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&/,%%%*&**.&&* &&%&&%%%%%%.@@@");//7 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&%#######%&@@&//%&@@%#((((((((#%&");//7
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@..%%#%%%%&%.,,,*,&%%%%&..@@@");//8 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@&%#%&@@@&@@@@@@%%#%#%%&@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@#@@*,..%%%&.*,,,,,,.&@@@@@@");//9 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@&&@@@@&@@@@@&&%%%%@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@..,****/****,..#@@@@@@@@@@@@");//10 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&&@@&@@@&&@@@@@@@@@@@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@%@..&&*.*.***/***.***(@@.&&%.#.@@");//11 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&&*,*&###&&@@@@@@@@@@@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@&,%&&&&&&&&.*.**&%%****&,&&(%#%,@@");//12 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&%/#./&/ %%#&##&&@@@@@@@@@@@");//12
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@#@.&*&,&&%#.,***,,.****. &&.%&&#@@");//13 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&#&&,%&% /(*/&&@@@@@@@@@@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@&,(&&&&&&(.***********,&.&&&%,&&@");//14 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&&@&&  #.  .&%##&%%&@@@@@@@@@@@");//14
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@%&@#*.**/*,.******,./**,.&@&%@@@");//15 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&/*%&&&((%&&###%%%#&&@@@@@@@@@@");//15
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@&@.*/*///*/.@./////*///*.&@@@@@");//16 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&#*%%&%#%&&&&##&&##%&#(&@@@@@@@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@#@.*////*/*,&@*.**////,.@&@@@@@");//17 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@&%#&&@&%%&&@@@@@@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@#@##..,.,@(@%%&&&@&&@&&@@@@@@@");//18 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    }
                    else if (enemy.Name == "Clubba")
                    {
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@@@@@@*..,***..@@@@@@@@@");//1 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@&@.,//***.&&&@/.@@@@@@@");//2 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@&@.****/***@*&&**.&@@@@@@");//3 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@&##&@@@@&@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@&@@@./*****,***/*/*/****/. @");//4 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@#(/,%(((#(&#@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@./**/*/...,....&&%%(... /@@&");//5 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&#&../(%*,&@@@@@@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&.,.%&#.**,%&%%%.%%%**(,.%@@@@");//6 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@&##((##%##&@@@@&/..%(&@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&/,%%%*&**.&&* &&%&&%%%%%%.@@@");//7 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&/##%%%(&#@@@&........,&@&@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@..%%#%%%%&%.,,,*,&%%%%&..@@@");//8 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&@&%%&@@%*////////%,,,,,&@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@#@@*,..%%%&.*,,,,,,.&@@@@@@");//9 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&%&%*(/&//////////.((&&@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@..,****/****,..#@@@@@@@@@@@@");//10 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@%*.**//////%////%..(###@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@%@..&&*.*.***/***.***(@@.&&%.#.@@");//11 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&#%/#%%(////%////(..#%%%&@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@&,%&&&&&&&&.*.**&%%****&,&&(%#%,@@");//12 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@(/(%&......%//////%.,&&&#@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@#@.&*&,&&%#.,***,,.****. &&.%&&#@@");//13 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@%#&&....(////(//////%&%(((/");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@&,(&&&&&&(.***********,&.&&&%,&&@");//14 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@%&&...*//#(..%////////(((%");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@%&@#*.**/*,.******,./**,.&@&%@@@");//15 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&%@&.......%/////((///(/%@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@&@.*/*///*/.@./////*///*.&@@@@@");//16 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&/*%&&&((%&&###%%%#&&@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@#@.*////*/*,&@*.**////,.@&@@@@@");//17 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@&%&@%(&/..,((/(((((%%&@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@#@##..,.,@(@%%&&&@&&@&&@@@@@@@");//18 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&%%%%%%%%%///(((@@@@@@@");//18
                    }
                    else
                    {//koopatrol
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@@@@@@*..,***..@@@@@@@@@");//1 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@&,&@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@@@&@.,//***.&&&@/.@@@@@@@");//2 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@# *,%@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@@@&@.****/***@*&&**.&@@@@@@");//3 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@&*/*&@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@&@@@./*****,***/*/*/****/. @");//4 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&&,,,,,#&@&@@@@@@@@@@@@@@@@@");
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@./**/*/...,....&&%%(... /@@&");//5 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@% .,**,,,,,,%#%@@@@@@@@@@@@@@");//5
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&.,.%&#.**,%&%%%.%%%**(,.%@@@@");//6 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@**&.&&*/&,**,%##&@@@@@@@@@@@@");//6
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@&/,%%%*&**.&&* &&%&&%%%%%%.@@@");//7 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&****,(&&&&&&/(*&&&%@@@@@@@@@@@@");//7
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@%@..%%#%%%%&%.,,,*,&%%%%&..@@@");//8 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&# *@**,*****@,*#,@&&&&%@@@@@@@@@@");//8
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@@#@@*,..%%%&.*,,,,,,.&@@@@@@");//9 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@&. ***,****//@,%@/@&&&&@@@@@@@@@@@");//9
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@@@..,****/****,..#@@@@@@@@@@@@");//10 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@& ,***,**%%*,,**%@&&@&@@&&*,&@@@@");//10
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@%@..&&*.*.***/***.***(@@.&&%.#.@@");//11 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@&&***&#//(%**%@#/%##&..,,,&@@@@@");//11
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@&,%&&&&&&&&.*.**&%%****&,&&(%#%,@@");//12 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@&*,,,**,&/.*%%**/&//#&@@");//12
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@#@.&*&,&&%#.,***,,.****. &&.%&&#@@");//13 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@&/////,&**&.%%&&&&&@@@@");//13
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@&,(&&&&&&(.***********,&.&&&%,&&@");//14 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&.,/(/&##%%@.,*/&.#&,..,&&@@");//14
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@%&@#*.**/*,.******,./**,.&@&%@@@");//15 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@&/%*/&**#,,,,,,(&.%&*,*(%&&@");//15
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@&@.*/*///*/.@./////*///*.&@@@@@");//16 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@&/*@..***&%,,.%@@@@@@@");//16
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@#@.*////*/*,&@*.**////,.@&@@@@@");//17 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@&&&&&&&&&&/**&&@@@@");//17
                        Console.CursorLeft = Console.BufferWidth - 130;
                        Console.Write("@@@@@#@##..,.,@(@%%&&&@&&@&&@@@@@@@");//18 M
                        Console.CursorLeft = Console.BufferWidth - 35;
                        Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");//18
                    }

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " J) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Super Jump\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " H) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Super Hammer\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " T) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Tattle\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " F) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Flee\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " Esc) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Quit Game");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    switch (userChoice)
                    {
                        case ConsoleKey.J:
                            //marioWeapon = weapon2;
                            mario2.EquippedWeapon = weapon2;
                            Console.Beep(100, 150);
                            Console.Beep(250, 150);
                            if (enemy.IsSpiked == true)
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.Beep(60, 200);
                                mario2.Life--;
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 90;
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
                                Console.CursorLeft = Console.BufferWidth - 83;
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

                                    Console.Beep(233, 200);
                                    Console.Beep(220, 200);
                                    Console.Beep(196, 200);
                                    Console.Beep(175, 360);
                                    System.Threading.Thread.Sleep(40);

                                    Console.Beep(196, 200);
                                    Console.Beep(220, 200);
                                    Console.Beep(233, 160);
                                    System.Threading.Thread.Sleep(240);
                                    Console.Beep(175, 160);
                                    System.Threading.Thread.Sleep(240);
                                    Console.Beep(233, 160);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 70);
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
                            mario2.EquippedWeapon = weapon3;
                            Console.Beep(200, 500);
                            System.Threading.Thread.Sleep(400);
                            Console.Beep(70, 100);
                            if (enemy.IsAir == true)
                            {
                                Console.WriteLine();
                                Console.CursorLeft = Console.BufferWidth - 92;
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

                                    Console.Beep(233, 200);
                                    Console.Beep(220, 200);
                                    Console.Beep(196, 200);
                                    Console.Beep(175, 360);
                                    System.Threading.Thread.Sleep(40);

                                    Console.Beep(196, 200);
                                    Console.Beep(220, 200);
                                    Console.Beep(233, 160);
                                    System.Threading.Thread.Sleep(240);
                                    Console.Beep(175, 160);
                                    System.Threading.Thread.Sleep(240);
                                    Console.Beep(233, 160);

                                    Console.WriteLine();
                                    Console.WriteLine();
                                    string defeat = $" You defeated the {enemy.Name}! ";
                                    int length = enemy.Name.Length;
                                    Console.CursorLeft = Console.BufferWidth - (length + 70);
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
        }
    }
}
