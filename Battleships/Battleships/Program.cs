using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = string.Empty;
            Console.WriteLine(CreateGameMap());



        }

        private static string CreateGameMap()
        {
            bool[,] gameMap = new bool[7, 5];

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    gameMap[x, y] = false;
                }
            }

            string draw = string.Empty;
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (gameMap[x, y] == true)
                    {
                        draw = " X ";
                    }
                    else
                    {
                        draw = " O ";
                    }
                    Console.Write(draw);
                }
                Console.WriteLine();

            }
            return draw;

        }

    }
}
