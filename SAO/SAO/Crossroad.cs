﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAO
{
    public class Crossroad
    {
        public int X { get; set; }
        public int Y { get; set; }

        //increase Y
        public Road North { get; set; }
        //decrease Y
        public Road South { get; set; }
        //decrease X
        public Road West { get; set; }
        //increase X
        public Road East { get; set; }

        public TrafficLightsState Lights {get; set; }
    }

    public enum TrafficLightsState
    {
        NorthSouth,
        WestEast
    }
}
