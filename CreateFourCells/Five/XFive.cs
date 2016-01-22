using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class XFive : Block {
		public override int[] region(int basePoint) {
			return new int[] { basePoint,
							   basePoint + convert,
							   basePoint + convert - 1,
							   basePoint + convert + 1,
							   basePoint + 2 * convert};
		}
		public override int[] areaNum() {
			return new int[] { 3, 0, 3, 3, 3 };
		}
	}
}
