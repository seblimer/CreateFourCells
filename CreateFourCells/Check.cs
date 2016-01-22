using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	//<summary>
	//Program.createBoardで生成された盤面が一意であるかチェックする為の機能群
	//<\summary>
	class Check {
		// メンバ変数についてはProgramクラスに同名のものが存在する場合,そちらを参照
		private int cells;
		const int check = 1; // 孤立チェックに際して,幅優先で一度みたマスのチェックのための定数
		int[,] board; // 盤面そのもの
		int[,] tmp; // 孤立チェックの時のクローン用（メンバ変数である必要はないがGCへの負担軽減)
		private int col;
		private int row;
		Dictionary<int, List<int>> numList;

		// コンストラクタ
		public Check(int cells, int col, int row) {
			this.cells = cells;
			this.col = col;
			this.row = row;
			board = new int[col, row];
			for(int i = 0; i < col; i++) {
				for(int j = 0; j < row; j++) {
					if(i == 0 || i == col - 1) {
						board[i, j] = -1;
					}
					else if(j == 0 || j == row - 1) {
						board[i, j] = -1;
					}
				}
			}
		}

		// Programクラス内でのGuessクラスで用いる
		// 現在盤面のクローン（別参照の中身が同じ）をつくって投げつける
		public Guess property {
			get { return new Guess((int[,])board.Clone()); }
			set { board = value.getBoard(); }
		}

		// 枠以外を初期化（0代入）
		public void clear() {
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					board[i, j] = 0;
				}
			}
		}

		// チェックするためのヒントマスのリスト
		public void nums(Dictionary<int, List<int>> list) {
			numList = list;
		}

		// ブロックの範囲（region）が盤面に適しているかチェック
		public bool match(int[] region) {
			foreach(int re in region) {
				if(board[re / row, re % row] != 0) {
					return false;
				}
			}
			return isolationCheck(region) && checkNumRule(region);
		}
		
		// 孤立チェック
		// チェックされていない（埋まっていない）マスでできる小領域毎にcellsで割り切れる面積かチェック
		// isolationCheck()で小領域の一点の発見と面積チェック
		// dps()で面積を求める（幅優先探索）
		public bool isolationCheck(int[] region) {
			tmp = (int[,])board.Clone();
			foreach(int re in region) {
				tmp[re / row, re % row] = check;
			}
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					if(tmp[i, j] == 0) {
						if(bps(i * row + j) % cells != 0) {
							return false;
						}
					}
				}
			}
			return true;
		}
		private int bps(int point) {
			int sum = new int();
			Queue<int> queue = new Queue<int>();
			tmp[point / row, point % row] = check;
			queue.Enqueue(point);
			while(queue.Count > 0) {
				point = queue.Dequeue();
				sum++;
				foreach(int re in cross(point)) {
					if(tmp[re / row, re % row] == 0) {
						tmp[re / row, re % row] = check;
						queue.Enqueue(re);
					}
				}
			}
			return sum;
		}

		// ヒントとそこに置くブロックの間に矛盾が無いかのチェック
		public bool checkNumRule(int[] region) {
			int count = new int();
			foreach(int re in region) {
				count = 0;
				foreach(int key in numList.Keys) {
					if(numList[key].Contains(re)) {
						foreach(int cr in cross(re)) {
							if(!region.Contains(cr)) {
								count++;
							}
						}
						if(key != count) {
							return false;
						}
						break;
					}
				}
			}
			return true;
		}

		// 指定された領域（ブロックの領域）を別の数字で置き換える
		// 代表点の取り方から0が現れるまでに置いた全てのブロックをチェックできるため
		// その中の最大値+1で置き換えるとn個目のブロックの領域であると分かるようになる
		public void paint(int[] point) {
			int num = 0;
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					if(board[i, j] > num) {
						num = board[i, j];
					}
					if(board[i, j] == 0) {
						i = j = Math.Max(col, row);
					}
				}
			}
			num++;
			foreach(int po in point) {
				board[po / row, po % row] = num;
			}
		}

		// 上の行は全部埋まり,かつ,その行で始めて0となるマスを代表点として返す
		public int unsettled() {
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					if(board[i, j] == 0) {
						return i * row + j;
					}
				}
			}
			return 0;
		}

		// 盤面が全て埋まっていれば完成
		// 0から置き換えて埋めていくため,0が無ければ完成
		public bool complete() {
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					if(board[i, j] == 0) {
						return false;
					}
				}
			}
			return true;
		}

		// 指定したマスの上下左右のマスの座標を返す
		public int[] cross(int basePoint) {
			return new int[] { basePoint - row, basePoint - 1, basePoint + 1, basePoint + row };
		}

		// 枠以外（盤面）を表示する
		public void write() {
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					System.Console.Write("{0,3}", board[i, j]);
				}
				System.Console.WriteLine();
			}
			System.Console.WriteLine();
		}
	}
}
