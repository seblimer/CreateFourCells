using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class SFourH : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + convert, 
							   basePoint + convert - 1 };
		}
		public override int[] areaNum() {
			return new int[] { 2, 3, 2, 3 };
		}
	}
	class SFourV : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert + 1, 
							   basePoint + 2 * convert + 1 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}

	class SFourTH : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + convert + 1, 
							   basePoint + convert + 2 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}
	class SFourTV : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1,
							   basePoint + 2 * convert - 1 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}
}
