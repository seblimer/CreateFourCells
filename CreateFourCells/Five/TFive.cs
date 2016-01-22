using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class TFiveU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + 2,
							   basePoint + convert + 1,
							   basePoint + 2 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 2, 3 };
		}
	}
	class TFiveR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert - 1,
							   basePoint + convert - 2,
							   basePoint + 2 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 2, 3, 3 };
		}
	}
	class TFiveD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert - 1,
							   basePoint + 2 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 1, 3, 3 };
		}
	}
	class TFiveL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert + 1,
							   basePoint + convert + 2,
							   basePoint + 2 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 2, 3, 3 };
		}
	}
}
