using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class YFiveU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1, 
							   basePoint + 2 * convert, 
							   basePoint + 3 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 2, 3 };
		}
	}
	class YFiveR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1, 
							   basePoint + convert - 2, 
							   basePoint + convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 2, 3, 3 };
		}
	}
	class YFiveD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 2 * convert + 1, 
							   basePoint + 3 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 1, 3, 3 };
		}
	}
	class YFiveL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + 3, 
							   basePoint + convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 2, 3, 3 };
		}
	}

	class YFiveTU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert + 1, 
							   basePoint + 2 * convert, 
							   basePoint + 3 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 2, 3 };
		}
	}
	class YFiveTR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + 3, 
							   basePoint + convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 1, 3, 3 };
		}
	}
	class YFiveTD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 2 * convert - 1, 
							   basePoint + 3 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 1, 3, 3 };
		}
	}
	class YFiveTL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1, 
							   basePoint + convert + 1, 
							   basePoint + convert + 2};
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 2, 3 };
		}
	}
}
