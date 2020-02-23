using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
        public new static void UpdatePosition(string key, out int changeInX, out int changeInY)
        {
            switch (key)
            {
                case "DownArrow":
                    changeInY = 1;
                    changeInX = 0;
                    break;
                case "UpArrow":
                    changeInY = -1;
                    changeInX = 0;
                    break;
                case "LeftArrow":
                    changeInY = 0;
                    changeInX = -1;
                    break;
                case "RightArrow":
                    changeInY = 0;
                    changeInX = 1;
                    break;
                default:
                    changeInY = 0;
                    changeInX = 0;
                    break;
            }
        }


        public new static char UpdateCursor(string keyInput)
        {
            switch (keyInput)
            {
                case "RightArrow":
                    return Convert.ToChar(">");
                case "LeftArrow":
                    return Convert.ToChar("<");
                case "DownArrow":
                    return Convert.ToChar("v");
                case "UpArrow":
                    return Convert.ToChar("^");
                default:
                    return Convert.ToChar(" ");
            }
        }


        public new static int KeepInBounds(int coordinate, int max)
        {
            if (coordinate > max)
            {
                return max - 1;
            } else if (coordinate < 0)
            {
                return 0;
            } else
            {
                return coordinate;
            }
        }


        public new static bool DidScore(int characterX, int characterY, int fruitX, int fruitY)
        {
            if (characterX == fruitX && characterY == fruitY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  }
}