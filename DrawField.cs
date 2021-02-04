using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class DrawField
    {
        private const int fieldWidth = 16;
        private const int fieldHeight = 16;
        private char solidBlock = '\u2588';
        private char leftUpperCorner = '\u2554';
        private char rightUpperCorner = '\u2557';
        private char leftDownCorner = '\u255A';
        private char rightDownCorner = '\u255D';
        private char roof = '\u2550';
        private char walls = '\u2551';
        private char empty = ' ';
        public int[,] field = new int[fieldWidth, fieldHeight]
            {{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
             { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 }};

        public void Draw()
        {
            for (int i = 0; i < fieldWidth; i++)
            {
                if (i == 0) Console.Write(leftUpperCorner);
                if (i < 16) { Console.Write(roof); Console.Write(roof); }
                if (i == 15) Console.WriteLine(rightUpperCorner);
            }

            for (int i = 0; i < fieldHeight; ++i)
            {
                Console.Write(walls);
                for (int j = 0; j < fieldWidth; ++j)
                {
                    if (field[i, j] == 0)
                    { Console.Write(empty); Console.Write(empty); }
                    if (field[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(solidBlock); Console.Write(solidBlock);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (field[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(solidBlock); Console.Write(solidBlock);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (field[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(solidBlock); Console.Write(solidBlock);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine(walls);
            }
            for (int i = 0; i < fieldWidth; i++)
            {
                if (i == 0) Console.Write(leftDownCorner);
                if (i < 16) { Console.Write(roof); Console.Write(roof); }
                if (i == 15) Console.WriteLine(rightDownCorner);
            }
        }
    }
}
