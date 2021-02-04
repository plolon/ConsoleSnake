using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class DrawScore
    {
        public int score=0;
        private const int width = 16;
        private const int height = 3;
        private char solidBlock = '\u2588';
        private char leftUpperCorner = '\u2554';
        private char rightUpperCorner = '\u2557';
        private char leftDownCorner = '\u255A';
        private char rightDownCorner = '\u255D';
        private char roof = '\u2550';
        private char walls = '\u2551';
        private char empty = ' ';
        public int[,] scorefield = new int[height, width]
            {{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 }};
        public void Draw()
        {
            for (int i = 0; i < width; i++)
            {
                if (i == 0) Console.Write(leftUpperCorner);
                if (i < 16) { Console.Write(roof); Console.Write(roof); }
                if (i == 15) Console.WriteLine(rightUpperCorner);
            }

            for (int i = 0; i < height; ++i)
            {
                Console.Write(walls);
                for (int j = 0; j < width; ++j)
                {
                    if (i == 1)
                    {
                        if (score==0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"           SCORE: {solidBlock}{solidBlock}{solidBlock}           ");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                        else if (score < 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"           SCORE: {solidBlock}{solidBlock}{score}           ");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                        else if (score >=10)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"           SCORE: {solidBlock}{score}           ");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }

                    }
                    else { Console.Write(empty); Console.Write(empty); }

                }
                Console.WriteLine(walls);
            }

            for (int i = 0; i < width; i++)
            {
                if (i == 0) Console.Write(leftDownCorner);
                if (i < 16) { Console.Write(roof); Console.Write(roof); }
                if (i == 15) Console.WriteLine(rightDownCorner);
            }

        }
    }
}
