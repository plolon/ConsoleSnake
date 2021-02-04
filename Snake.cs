using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Snake
    {
        static Random r1 = new Random();
        public int posX = 8;
        public int posY = 8;
        public int length=3;
        public int[] pastPosX = new int[10000];
        public int[] pastPosY = new int[10000];
        public int direction = 0;

        public void Move()
        {
            if (direction == 0) posY--;   // Up
            { if (posY == -1) posY = 15; }
            if (direction == 1) posY++;   // Down
            { if (posY == 16) posY = 0; }
            if (direction == 2) posX--;   // Left
            { if (posX == -1) posX = 15; }
            if (direction == 3) posX++;   // Right
            { if (posX == 16) posX = 0; }
        }

    }
}
