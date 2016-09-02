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
            //Keeps count of boats
            int boats = r.Next(3, 6);
            //Keeps count of total shots fired
            int shotsFired = 0;

            //Creates gamemap
            CreateGameMap();
            //Places boats on map
            PlaceBoats(boats);
            //Draws the gamemap in the console
            DrawGameMap();

            //While loop for shooting at the map
            while (boats > 0)
            {
                if (ShootRandomly(r.Next(0,7), r.Next(0,5)))
                {
                    boats--;
                }
                shotsFired++;
            }
            Console.WriteLine(shotsFired);
        }

        //The gamemap
        static bool[,] gameMap = new bool[7, 5];
        //Randomizer
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
        //Shoots boats at random places
        private static bool ShootRandomly(int x, int y)
        {
            if (gameMap[x, y])
            {
                gameMap[x, y] = false;
                return true;
            }
            return false;
        }
    }
}
