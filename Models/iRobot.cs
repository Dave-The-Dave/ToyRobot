using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Models
{
    public interface iRobot :iToy
    {
        void Move();
        void Left();
        void Right();

    }
}
