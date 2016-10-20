using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RicochetRobots
{
    public class Robot
    {
        public enum Colors {RED, YELLOW, BLUE, GREEN, BLACK};

        public Colors Color {get;set;}
        public Position CurrentPosition {get;}
        public Robot(Colors color, Position currentPosition)
        {
            Color = color;
            CurrentPosition = currentPosition;
        }
    }
}