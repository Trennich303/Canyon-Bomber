using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Canyon_Bomber
{
    internal class Bombs1
    {
        public int size = 10;
        public int xSpeed, ySpeed;
        public int x, y;

        public Bombs1(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Move(Size screenSize)
        {
            x += xSpeed;
            y += ySpeed;
        }

        }
    }
