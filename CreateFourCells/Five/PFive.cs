using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class PFiveU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert,
							   basePoint + convert + 1,
							   basePoint + 2 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 1, 2, 3 };
		}
	}
	class PFiveR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + 2,
							   basePoint + convert + 1,
							   basePoint + convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 2, 2, 2 };
		}
	}
	class PFiveD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert - 1,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert - 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 2 };
		}
	}
	class PFiveL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert,
							   basePoint + convert + 1,
							   basePoint + convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 2, 1, 3 };
		}
	}

	class PFiveTU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert,
							   basePoint + convert + 1,
							   basePoint + 2 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 2, 1, 3 };
		}
	}
	class PFiveTR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert,
							   basePoint + convert - 1,
							   basePoint + convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 1, 3, 2 };
		}
	}
	class PFiveTD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert + 1,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 2, 2, 2 };
		}
	}
	class PFiveTL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + 2,
							   basePoint + convert,
							   basePoint + convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 2, 1, 3, 2, 2 };
		}
	}
}
