using System;
namespace VSCodeTry1
{
    public class Square
    {
        private int x;
        private int y;
        private int w;
        public Square(int width, int xLocation = 0, int yLocation = 0)
        {
            w = width;
            x = xLocation;
            y = yLocation;
        }
        public int[] Location()
        {
            int[] location = new int[2];
            location[0] = x;
            location[1] = y; 
            return location;
        }
        
    }
}