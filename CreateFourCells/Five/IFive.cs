using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class IFiveV : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 3 * convert, 
							   basePoint + 4 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}

	class IFiveH : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + 3, 
							   basePoint + 4 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
}
