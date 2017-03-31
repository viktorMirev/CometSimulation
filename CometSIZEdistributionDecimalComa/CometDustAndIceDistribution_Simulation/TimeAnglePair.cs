using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CometDustAndIceDistribution_Simulation
{
    class TimeAnglePair
    {
        public int Time { get; set; }
        public double Angle { get; set; }
        public TimeAnglePair(int t, double a)
        {
            this.Time = t;
            this.Angle = a;
        }
    }
}
