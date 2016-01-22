using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class NFiveU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert - 1,
							   basePoint + 3 * convert - 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class NFiveR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert + 1,
							   basePoint + convert + 2,
							   basePoint + convert + 3};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class NFiveD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert - 1,
							   basePoint + 2 * convert - 1,
							   basePoint + 3 * convert - 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class NFiveL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + 2,
							   basePoint + convert + 2,
							   basePoint + convert + 3};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}

	class NFiveTU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert + 1,
							   basePoint + 3 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class NFiveTR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + 2,
							   basePoint + convert,
							   basePoint + convert - 1};
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 3, 2, 3 };
		}
	}
	class NFiveTD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert + 1,
							   basePoint + 2 * convert + 1,
							   basePoint + 3 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class NFiveTL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + convert,
							   basePoint + convert - 1,
							   basePoint + convert - 2};
		}
		public override int[] areaNum() {
			return new int[] { 2, 3, 2, 2, 3 };
		}
	}
}
