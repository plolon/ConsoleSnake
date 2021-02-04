using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Apple
    {
        public int posX;
        public int posY;

        Random rand = new Random();

        public void GenerateLocation()
        {
            posX = rand.Next(0, 16);
            posY = rand.Next(0, 16);
        }
    }
}
