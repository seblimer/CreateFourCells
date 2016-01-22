using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class Program {
		static int col = 6; // 生成する盤面の行数
		static int row = 6; // 生成する盤面の列数
		static int cells = 4; // 4or5 それ以外では答えが出ない（無限ループ）
		const int HintRate = 2; // 最終出力の全マスに対する,ヒントマスのおおよその割合
		static Dictionary<int, List<int>> numList; // 数字マスのリスト
		private static Block[] blocks; // テトロミノまたはペントミノの配列. cellsに依存
		private static Create create; // 盤面生成用
		private static Check check; //一意性チェック用
		private static Guess current = null; // バックトラックでの盤面保存用

		// 入力マスを用いてヒントマスのリスト作成
		// 実際の登録はaddNumListで行う
		public static void entryNum(int[,] initial) {
			numList = new Dictionary<int, List<int>>();
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					if(initial[i, j] != 5 && initial[i,j] != 0) { // ヒントは0から4を検討（要検証）
						addNumList(initial[i, j], i * row + j);
					}
				}
			}
		}
		public static void addNumList(int key, int value) {
			if(!numList.ContainsKey(key)) {
				List<int> nums = new List<int>();
				nums.Add(value);
				numList.Add(key, nums);
			}
			else {
				numList[key].Add(value);
			}
		}

		// バックトラック用
		// 各場合について複製した盤面をもつGuessの操作でバックトラックを行う
		// guess()では幅優先的に次に取りうる盤面をcurrentのQueueに追加
		// nextGuess()ではQueueから次の盤面の取り出し,現在盤面の切り替えを行う
		public static void guess() {
			int point = check.unsettled();
			foreach(Block bl in blocks) {
				if(check.match(bl.region(point))) {
					Guess tmp = check.property;
					check.property = tmp;
					check.paint(bl.region(point));
					current.entryChild(tmp);
					check.property = current;
				}
			}
		}
		public static void nextGuess() {
			current = current.next();
			if(current != null) {
				check.property = current;
			}
		}

		// 全てのマスにヒントがある盤面を1つ生成
		public static void createBoard() {
			create.clear();
			int point;
			List<Block> poss = new List<Block>();
			while(!create.complete()) {
				create.clear();
				while(true) {
					point = create.unsettled();
					poss.Clear();
					foreach(Block bl in blocks) {
						if(create.match(bl.region(point))) {
							poss.Add(bl);
						}
					}
					if(poss.Count == 0) {
						break;
					}
					//possのなかからランダムで一つ選ぶ
					poss = poss.OrderBy(i => Guid.NewGuid()).ToList<Block>();
					create.paint(poss[0].region(point), poss[0].areaNum());
				}
			}
		}
		// createが一意に解けるか否かのチェック
		public static bool checkUnique(int[,] initial) {
			int count = 0;
			check.clear();
			entryNum(initial);
			check.nums(numList);
			current = check.property;

			while(true) {
				if(!current.Check) {
					current.Check = true;
					guess();
				}
				if(check.complete()) {
					if(++count >= 2) {
						return false;
					}
				}
				nextGuess();
				if(current == null) {
					break;
				}
			}
			return count == 1 ? true : false;
		}

		static void Main(string[] args) {
			col += 2; // 番兵用の外枠追加
			row += 2; // 番兵用の外枠追加
			create = new Create(cells, col, row); // 盤面生成用
			check = new Check(cells, col, row); // 生成した盤面が一意か確認用
			blocks = Blocks.blocks(row, cells); // テトロミノかペントミノの集合（配列）を返す
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); // 一応時間計測
			sw.Start();
			do {
				createBoard();
			} while(!checkUnique(create.initial()));
			int hintNum = (int)Math.Round((row - 2) * HintRate / 10.0); // HintRateに適した行当たりのヒント数
			int[] colHintNum = new int[col - 2]; // 行毎のヒント数格納用
			Random rnd = new Random();
			for(int i = 0; i < colHintNum.Length; i++) { // 各行毎のヒント数を最大hintNumとして割り振る
				colHintNum[i] = rnd.Next(hintNum + 1);
				System.Console.Write("{0,2}", colHintNum[i]);
			}
			System.Console.WriteLine();
			int[,] comp = create.initial(); // 一意性のある盤面
			int[,] result = new int[col, row]; // 最終出力
			for(int i = 0; i < col; i++) { // resultの初期化
				for(int j = 0; j < row; j++) {
					if(i == 0 || i == col - 1) {
						result[i, j] = -1;
					}
					else if(j == 0 || j == row - 1) {
						result[i, j] = -1;
					}
					if(comp[1, j] == 1) {
						result[i, j] = 1;
					}
				}
			}
			int point; // 最終出力に引き継ぐヒントマスの場所（列）
			for(int i = 1; i < col - 1; i++) {
				for(int h = 0; h < colHintNum[i - 1]; h++) {
					if(result[i, point = rnd.Next(1, row - 1)] == 0) {
						result[i, point] = comp[i, point];
					}
					else {
						continue;
					}
				}
			}
			// 完全ランダムではなく, その他もろもろと区別が付きにくい部分をあぶりだして
			// そこらへんに置くように変更したい
			int x; // 完全ランダム用（行）
			int y; // 完全ランダム用（列）
			while(!checkUnique(result)) {
				if(result[x = rnd.Next(1, col - 1), y = rnd.Next(1, row - 1)] == 0) {
					result[x, y] = comp[x, y];
				}
			}
			sw.Stop();
			create.write(); // 完成盤面の出力
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					System.Console.Write("{0,2}", result[i, j]);
				}
				System.Console.WriteLine();
			}
			System.Console.WriteLine("\n{0}", checkUnique(result));
			System.Console.WriteLine();
			System.Console.WriteLine("time : {0}", sw.Elapsed);
			System.Console.Write("Enterで終了");
			System.Console.ReadLine();
		}
	}
}
