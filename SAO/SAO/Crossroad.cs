﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAO
{
    public class Crossroad
    {
		private static int lastId = -1;

		private static int GetUniqueId()
		{
			++lastId;
			return lastId;
		}

		public Crossroad(int y, int x)
		{
			Id = GetUniqueId();
			X = x;
			Y = y;
			North = null;
			South = null;
			West = null;
			East = null;
		}

		public int Id { get; set; }

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

		public TrafficLights Lights { get; set; }

        public TrafficLightsState LightsState { get; set; }
    }

    public enum TrafficLightsState
    {
        NorthSouth,
        WestEast
    }
}
