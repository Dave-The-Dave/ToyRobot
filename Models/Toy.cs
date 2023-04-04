using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Models
{
    public class Toy : iToy
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }

        private bool Placed = false;

        public Table _table;

        public Toy(Table table)
        {
            _table = table;
        }

        public bool IsPlaced()
        {
            return Placed;
        }

        public void Place(int x, int y, Direction facing)
        {
            if (!_table.IsValidPosition(x, y))
            {
                // return error: posistion is outside of the table
                return;
            }

            X = x;
            Y = y;
            Facing = facing;
            Placed = true;
        }

        public void Rotate(Direction facing)
        {
            if (!Placed)
            {
                // return error: toy has not been placed
                return;
            }

            Facing = facing;
        }

        public string Report()
        {
            if (!Placed)
                return "Error: Robot has not been placed.";

            return $"{X},{Y},{Facing}";
        }

    }
}
