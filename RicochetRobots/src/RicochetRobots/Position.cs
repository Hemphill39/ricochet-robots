using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RicochetRobots
{
    public class Position
    {
        public int X {get;private set;}
        public int Y {get;private set;}
         
        public Position(int x, int y)
        {
            X = x;
            y = Y;
        }
    }
}