using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отрисовка рамки
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            topLine.DrawLine();
            bottomLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            //отрисовка точки
            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();
            

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
