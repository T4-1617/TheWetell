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
            int boats = r.Next(3, 6);

            CreateGameMap();
            PlaceBoats(boats);
            DrawGameMap();

        }

        static bool[,] gameMap = new bool[7, 5];
        static Random r = new Random();

        //Creates the gamemap
        private static void CreateGameMap()
        {

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    gameMap[x, y] = false;
                }
            }
        }
        //Creates boats
        private static void PlaceBoats(int boatsToPlace)
        {

            int newBoats = 0;
            while (newBoats < boatsToPlace)
            {
                int x = r.Next(0, 7);
                int y = r.Next(0, 5);

                if (gameMap[x, y] == false)
                {
                    gameMap[x, y] = true;
                    newBoats++;
                }
            }
        }
        //Draw gamemap
        private static void DrawGameMap()
        {
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
        }

    }
}
