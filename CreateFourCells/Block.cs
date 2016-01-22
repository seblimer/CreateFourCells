﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	abstract class Block {
		protected static int convert;
		public static int Convert {
			set { convert = value; }
		}

		public abstract int[] region(int basePoint);
		public abstract int[] areaNum();
	}
}