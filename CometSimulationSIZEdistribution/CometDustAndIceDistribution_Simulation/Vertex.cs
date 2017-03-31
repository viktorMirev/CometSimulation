using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace CometDustAndIceDistribution_Simulation
{
    class Vertex
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vertex(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void SetPix(int x, int y, Bitmap immage, Color c)
        {
            immage.SetPixel(x, y, c);
        }
    }
}
