using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class LFourU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 2 * convert + 1 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}
	class LFourR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + convert };
		}
		public override int[] areaNum() {
			return new int[] { 2, 2, 3, 3 };
		}
	}
	class LFourD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + convert + 1, 
							   basePoint + 2 * convert + 1 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}
	class LFourL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1, 
							   basePoint + convert - 2 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}

	class LFourTU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + 2 * convert, 
							   basePoint + 2 * convert - 1 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}
	class LFourTR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert + 1, 
							   basePoint + convert + 2 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}
	class LFourTD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + convert, 
							   basePoint + 2 * convert };
		}
		public override int[] areaNum() {
			return new int[] { 2, 3, 2, 3 };
		}
	}
	class LFourTL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + convert + 2 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 2, 2, 3 };
		}
	}
}
