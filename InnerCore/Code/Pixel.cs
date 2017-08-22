using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerCore
{
    public enum PixelColor
    {
        INIT,
        WHITE,
        BLACK,
    }

    public class Pixel
    {
        public int X { set; get; }
        public int Y { set; get; }
        public PixelColor Color { set; get; }


        public Pixel()
        {
            X = 0;
            Y = 0;
        }

        public Pixel(int X_, int Y_, PixelColor Color_)
        {
            X = X_;
            Y = Y_;
            Color = Color_;
        }

    }

}
