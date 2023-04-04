using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Models
{
    public interface iToy
    {
        bool IsPlaced();
        void Place(int x, int y, Direction facing);
        void Rotate(Direction facing);
        string Report();
    }
}
