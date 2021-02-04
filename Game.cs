using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCsharp
{
    class Game
    {
        public int tick;
        public bool isRunning = true;
        private ConsoleKeyInfo key;
        DrawField field = new DrawField();
        Snake snake = new Snake();
        Apple apple = new Apple();
        public DrawScore score = new DrawScore();
        public void RenderSnake()
        {
            field.field[snake.posY, snake.posX] = 1;
            snake.pastPosX[tick] = snake.posX;
            snake.pastPosY[tick] = snake.posY;
            if (tick>0)
            field.field[snake.pastPosY[tick-1], snake.pastPosX[tick-1]] = 3;
        }
        public void Colision()
        {
            if (field.field[snake.posY, snake.posX] == 3)
            {
                Close();
            }
        }
        public void Eating()
        {
            if (field.field[snake.posY,snake.posX]==2)
            {
                snake.length++;
                score.score++;
            }
        }
        public void RemoveTail()
        {
            if ( tick>=snake.length)
            {
                field.field[snake.pastPosY[tick - snake.length], snake.pastPosX[tick - snake.length]] = 0;
            }
        }
        public void RenderApple()
        {
            while(field.field[apple.posY, apple.posX] == 1 || field.field[apple.posY, apple.posX] == 3)
            {
                apple.GenerateLocation();
            }
            field.field[apple.posY, apple.posX] = 2;
        }
        public void HandleEvents()
        {
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) Close();              // Close
                else if (key.Key == ConsoleKey.UpArrow && snake.direction!=1) snake.direction = 0;       // Up
                else if (key.Key == ConsoleKey.DownArrow && snake.direction != 0) snake.direction = 1;     // Down
                else if (key.Key == ConsoleKey.LeftArrow && snake.direction != 3) snake.direction = 2;     // Left
                else if (key.Key == ConsoleKey.RightArrow && snake.direction != 2) snake.direction = 3;    // Right
            }
        }
        public void Update()
        {
            Colision();
            Eating();
            RenderSnake();
            RemoveTail();
            RenderApple();
            snake.Move();
            field.Draw();
            score.Draw();
            HandleEvents();
        }
        public void Close()
        {
            isRunning = false;
        }
    }
}
