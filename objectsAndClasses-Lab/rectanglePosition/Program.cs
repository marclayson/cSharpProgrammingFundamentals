using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
           Rectangle     r2 = ReadRectangle();
            if (r1.Isinside(r2))
            {

            }

        }

        public static Rectangle ReadRectangle()
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle();
            {
                Left = sizes[0];
                Top = sizes[1];
                Width = sizes[2];
                Height = sizes[3];
            }
            return rectangle;
            
        }

        public bool IsInside(Rectangle other)
        {
            var isInLeft = Left >= other.Left;
            var isInRight = Right <= other.Right;
            var isInsideHorizontal = isInLeft && isInRight;
            var isInTop = Top >= other.Top;
            var isInBottom = Bottom <= other.Bottom;
            var isInsideVertical = isInTop && isInBottom;
            return isInsideHorizontal && isInsideVertical;
        }

    }
    public class Rectangle
    {
        
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right { get { return Left + Width; } }
        public int Bottom { get { return Top + Height; } }
    }
}
