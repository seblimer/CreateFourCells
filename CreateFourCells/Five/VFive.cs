using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class VFiveU : Block{
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert - 1,
							   basePoint + 2 * convert - 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class VFiveR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + 2 * convert,
							   basePoint + 2 * convert + 1,
							   basePoint + 2 * convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class VFiveD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + 2,
							   basePoint + convert,
							   basePoint + 2 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 3, 2, 3 };
		}
	}
	class VFiveL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + 1,
							   basePoint + 2,
							   basePoint + convert + 2,
							   basePoint + 2 * convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
}
