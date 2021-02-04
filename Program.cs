using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snakeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            End end = new End();

            while (game.isRunning)
            {
                Console.CursorVisible = false;
                game.Update();
                Console.SetCursorPosition(0, 0);
                game.tick++;
                Thread.Sleep(200);
            }
            Console.Clear();
            end.Draw();
            game.score.Draw();
            Console.ReadKey();

        }
    }
}
