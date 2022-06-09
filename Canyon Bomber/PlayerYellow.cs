using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Canyon_Bomber
{
    internal class PlayerYellow
    {
        // Creating the dimensions and height of the yellow plane.
        public int height = 60;
        public int width = 30;
        public int xSpeed;
        public int x, y;
        public int size = 10;
        

        public PlayerYellow(int _x, int _y, int _xSpeed)
        {
            x = _x;
            xSpeed = _xSpeed;
            y = _y;
        }
        public void Move(Size screenSize)
        {
            // Adding the speed to the x position to make the yellow plane move
           x = x + xSpeed;

            if (x > screenSize.Width - size || x < 0)
            {
                x = 0;
            }
        }
    }
}
