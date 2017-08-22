using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerCore
{
    class Letter
    {
        public string key { set; get; }

        public List<Pixel> Pixellist = new List<Pixel>();


        public void AddPixel(Pixel new_Pixel)
        {
            Pixellist.Add(new_Pixel);
        }

        public Letter(string key_)
        {
            key = key_;
        }
    }
}
