using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Models
{
    public class Robot : Toy, iRobot
    {

        public Robot(Table table)
            : base(table)
        {

        }

        public void Move()
        {
            //moves robot forward one space
            //check if toy has been placed
            if (!this.IsPlaced())
                return;

            int newX = X;
            int newY = Y;

            switch (this.Facing)
            {
                case Direction.NORTH:
                    newY++;
                    break;

                case Direction.EAST:
                    newX++;
                    break;

                case Direction.SOUTH:
                    newY--;
                    break;

                case Direction.WEST:
                    newX--;
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
            //rotate left 90 degrees
            if (!IsPlaced())
                return;

            switch (Facing)
            {
                case Direction.NORTH:
                    this.Rotate(Direction.WEST);
                    break;

                case Direction.SOUTH:
                    this.Rotate(Direction.EAST);
                    break;

                case Direction.EAST:
                    this.Rotate(Direction.NORTH);
                    break;

                case Direction.WEST:
                    this.Rotate(Direction.SOUTH);
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
