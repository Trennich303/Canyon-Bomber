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
        public int size = 8;
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
        public bool Collision(Block b)
        {
            Rectangle Bombs1 = new Rectangle(x, y, size, size);

            Rectangle Block = new Rectangle(b.x, b.y, b.height, b.width);

            if (Bombs1.IntersectsWith(Block))
            {


                return true;


            }

            return false;
        }
    }
    }
