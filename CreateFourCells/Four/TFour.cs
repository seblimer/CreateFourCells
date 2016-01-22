using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class TFourU : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1, 
							   basePoint + convert + 1 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 3 };
		}
	}
	class TFourR : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert, 
							   basePoint + convert + 1, 
							   basePoint + 2 * convert };
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 3 };
		}
	}
	class TFourD : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + 1, 
							   basePoint + 2, 
							   basePoint + convert + 1 };
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 3 };
		}
	}
	class TFourL : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint, 
							   basePoint + convert, 
							   basePoint + convert - 1, 
							   basePoint + 2 * convert };
		}
		public override int[] areaNum() {
			return new int[] { 3, 1, 3, 3 };
		}
	}
}
