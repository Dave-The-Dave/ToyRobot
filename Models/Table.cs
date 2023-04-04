using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Models
{
    public class Table
    {
        public int X { get; }
        public int Y { get; }

        public Table(int size)
        {
            //if one constraint given, assume square
            X = size;
            Y = size;
        }

        public Table(int width, int length) 
        {
            X = width;
            Y = length;
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < X && y >= 0 && y < Y;
        }
    }

}
