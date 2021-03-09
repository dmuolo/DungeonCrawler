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

            #region You Win!
            Console.Beep(220, 150);
            Console.Beep(220, 150);
            Console.Beep(233, 150);
            Console.Beep(220, 150);
            Console.Beep(196, 150);
            Console.Beep(175, 150);
            Console.Beep(131, 150);
            Console.Beep(175, 150);
            Console.Beep(196, 250);
            System.Threading.Thread.Sleep(350);
            Console.Beep(262, 150);
            Console.Beep(262, 800);
            System.Threading.Thread.Sleep(400);

            Console.Beep(208, 900);
            Console.Beep(233, 900);
            Console.Beep(262, 900);

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine();
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@&/*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@....***********%@@...@@@@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@...@@@***************@@@@@#.@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@..@@@@@*****************@@@@@@@.@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@.&@@@@@@*****************@@@@*****.@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@.****@@@@@***************@@@@******,.@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@.******@@@@@#*********&@@@@@@******,.@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@.*******@@@@@@@@@@@@@@@@@@@@@******,.@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@.*******@@@@@@@@/.......(%@@@@****,,.@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@.******@@@@.&&&&&&&&&.&&&&.,%&@,,,.@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@.****@@@.&&&&..&&&&&..&&&#.%%%%#.@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@.,%%%%%.&&&&&&&&&&&&&&&&##,%..@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@..%%#&&&&&&,,,,,,&&&&##.@@.&..&.@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@.&&&&&&.**.&&&###.#..&&&&&&.@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@,.#%&&&&&&##%..&&&&&&##/..&@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@..,,.#####.&**.&##.@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@.&.**..&&&&&&****,..@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@%.&.***.*@@@@@@*&.**,,.@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@/&&&&.****.#@@@@@@@.*.....@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@/.&&&&#.@@@@@@@@@@@@@@%%,.@@@@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@.....@@@@@@@@@@@%%%*,*,..@@@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@..*******..%%%%%%%/..,,*****,.@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@.**********,,.@@.,,,********,.@@@@@@@@@@@@");
            Console.CursorLeft = Console.BufferWidth - 95;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@..*******,,,.*@@@...**,,,,...@@@@@@@@@@@@@");

            string ending = String.Format("{0, " + 90 + "}", "I'm sorry, but the princess is in another castle!");
            Console.WriteLine();
            Console.WriteLine();
            foreach (char c in ending)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(100);
            }
            System.Threading.Thread.Sleep(2000);

            Console.Beep(131, 600);
            Console.Beep(147, 900);
            System.Threading.Thread.Sleep(100);
            Console.Beep(147, 600);
            Console.Beep(165, 500);
            System.Threading.Thread.Sleep(100);
            Console.Beep(196, 100);
            Console.Beep(175, 100);
            Console.Beep(165, 200);

            System.Threading.Thread.Sleep(1000);
            Console.Beep(131, 600);
            Console.Beep(147, 900);
            System.Threading.Thread.Sleep(100);
            Console.Beep(147, 600);
            Console.Beep(165, 500);
            System.Threading.Thread.Sleep(100);
            Console.Beep(196, 100);
            Console.Beep(175, 100);
            Console.Beep(165, 200);

            Console.Beep(131, 600);
            Console.Beep(147, 900);
            System.Threading.Thread.Sleep(100);
            Console.Beep(147, 600);
            Console.Beep(165, 500);
            System.Threading.Thread.Sleep(100);
            Console.Beep(196, 100);
            Console.Beep(175, 100);
            Console.Beep(165, 200);

            Console.Beep(131, 600);
            Console.Beep(147, 900);
            System.Threading.Thread.Sleep(100);
            Console.Beep(147, 600);
            Console.Beep(165, 500);
            System.Threading.Thread.Sleep(100);
            Console.Beep(196, 100);
            Console.Beep(175, 100);
            Console.Beep(165, 200);

            string thankYou = String.Format("{0, " + 84 + "}", "Thank you for playing my game!");
            foreach (char c in thankYou)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(40);
            }

            System.Threading.Thread.Sleep(3000);
            #endregion
        }
    }
}
