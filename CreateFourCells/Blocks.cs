using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class Blocks {
		public static Block[] blocks(int convert, int cells) {
			Block.Convert = convert;
			if(cells == 4) {
				return new Block[] {	new LFourU(), new LFourR(), new LFourD(), new LFourL(),
										new LFourTU(), new LFourTR(), new LFourTD(), new LFourTL(),
										new SFourH(), new SFourV(),
										new SFourTH(), new SFourTV(),
										new OFour(),
										new TFourU(), new TFourR(), new TFourD(), new TFourL(),
										new IFourV(), new IFourH()};
			}
			else if(cells == 5) {
				return new Block[] { new IFiveH(), new IFiveV(),
									   new LFiveU(), new LFiveR(), new LFiveD(), new LFiveL(),
									   new LFiveTU(), new LFiveTR(), new LFiveTD(), new LFiveTL(),
									   new YFiveU(), new YFiveR(), new YFiveD(), new YFiveL(),
									   new YFiveTU(), new YFiveTR(), new YFiveTD(), new YFiveTL(),
									   new VFiveU(), new VFiveR(), new VFiveD(), new VFiveL(),
									   new TFiveU(), new TFiveR(), new TFiveD(), new TFiveL(),
									   new FFiveU(), new FFiveR(), new FFiveD(), new FFiveL(),
									   new FFiveTU(), new FFiveTR(), new FFiveTD(), new FFiveTL(),
									   new ZFiveV(), new ZFiveH(), 
									   new ZFiveTV(), new ZFiveTH(),
									   new PFiveU(), new PFiveR(), new PFiveD(), new PFiveL(),
									   new PFiveTU(), new PFiveTR(), new PFiveTD(), new PFiveTL(),
									   new UFiveU(), new UFiveR(), new UFiveD(), new UFiveL(),
									   new NFiveU(), new NFiveR(), new NFiveD(), new NFiveL(),
									   new NFiveTU(), new NFiveTR(), new NFiveTD(), new NFiveTL(),
									   new XFive(),
									   new WFiveU(), new WFiveR(), new WFiveD(), new WFiveL()};
			}
			return new Block[] { };
		}
	}
}
