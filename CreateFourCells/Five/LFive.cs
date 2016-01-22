using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class LFiveU : Block{
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 3 * convert, 
							   basePoint + 3 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class LFiveR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + 3, 
							   basePoint + convert};
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 2, 3, 3 };
		}
	}
	class LFiveD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + convert + 1, 
							   basePoint + 2 * convert + 1, 
							   basePoint + 3 * convert + 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class LFiveL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1, 
							   basePoint + convert - 2, 
							   basePoint + convert - 3};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}

	class LFiveTU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 3 * convert, 
							   basePoint + 3 * convert - 1};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class LFiveTR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert + 1, 
							   basePoint + convert + 2, 
							   basePoint + convert + 3};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
	class LFiveTD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 3 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 2, 3, 2, 2, 3 };
		}
	}
	class LFiveTL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + 3, 
							   basePoint + convert + 3};
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 2, 3 };
		}
	}
}
