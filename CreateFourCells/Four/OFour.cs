using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class OFour : Block{
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + convert, 
							   basePoint + convert + 1 };
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 2, 2 };
		}
	}
}
