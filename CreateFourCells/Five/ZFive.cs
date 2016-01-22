using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class ZFiveV : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert + 1,
							   basePoint + 2 * convert + 1,
							   basePoint + 2 * convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class ZFiveH : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert - 1,
							   basePoint + convert - 2,
							   basePoint + 2 * convert - 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}

	class ZFiveTV : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert - 1};
		}
		public override int[] areaNum() {
			return new int[] { 2, 3, 2, 2, 3 };
		}
	}
	class ZFiveTH : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert + 1,
							   basePoint + convert + 2,
							   basePoint + 2 * convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
}
