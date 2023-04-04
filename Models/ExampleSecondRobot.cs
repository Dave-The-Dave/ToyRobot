using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Models
{
    public class ExampleSecondRobot : Toy, iRobot
    {
        //Class is strictly for example purposes of showing the advanatages to implement inheritance and interfaces
        public ExampleSecondRobot(Table table)
           : base(table)
        {

        }

        public void Move()
        {
            //Moves 3 squares
            if (!this.IsPlaced())
                return;

            int newX = X;
            int newY = Y;

            switch (this.Facing)
            {
                case Direction.NORTH:
                    newY = Y + 3;
                    break;

                case Direction.EAST:
                    newX = X + 3;
                    break;

                case Direction.SOUTH:
                    newY = Y - 3;
                    break;

                case Direction.WEST:
                    newX = X - 3;
                    break;

                default:
                    return;
            }

            if (!this._table.IsValidPosition(newX, newY))
            {
                // Move would cause the robot to fall off the table
                return;
            }

            //set new location
            this.Place(newX, newY, this.Facing);

        }

        public void Left()
        {
            //rotate left 180 degrees
            if (!IsPlaced())
                return;

            switch (Facing)
            {
                case Direction.NORTH:
                    this.Rotate(Direction.SOUTH);
                    break;

                case Direction.SOUTH:
                    this.Rotate(Direction.NORTH);
                    break;

                case Direction.EAST:
                    this.Rotate(Direction.WEST);
                    break;

                case Direction.WEST:
                    this.Rotate(Direction.EAST);
                    break;

                default:
                    break;
            }
        }

        public void Right()
        {
            //rotate right 90 degrees
            if (!IsPlaced())
                return;

            switch (Facing)
            {
                case Direction.NORTH:
                    this.Rotate(Direction.EAST);
                    break;

                case Direction.SOUTH:
                    this.Rotate(Direction.WEST);
                    break;

                case Direction.EAST:
                    this.Rotate(Direction.SOUTH);
                    break;

                case Direction.WEST:
                    this.Rotate(Direction.NORTH);
                    break;

                default:
                    break;
            }
        }
    }
}
