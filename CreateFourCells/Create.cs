using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	//<summary>
	//全てのマスにヒントのある盤面を生成するための機能群
	//<\summary>
	class Create {
		// 基本的にはCheckクラスと同様
		// 差分だけ記すため,表記のない部分はCheckクラス参照
		private int cells;
		const int check = 1;
		private int[,] board;
		int[,] tmp;
		private int col;
		private int row;
		Dictionary<int, List<int>> numList = new Dictionary<int, List<int>>();

		// コンストラクター
		public Create(int cells, int col, int row) {
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

		public void clear() {
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					board[i, j] = 0;
				}
			}
		}

		// 盤面を投げつける
		// Programクラス内での一意性確認用
		public int[,] initial() {
			return board;
		}

		public bool match(int[] region) {
			foreach(int re in region) {
				if(board[re / row, re % row] != 0) {
					return false;
				}
			}
			return isolationCheck(region);
		}

		public bool isolationCheck(int[] region) {
			tmp = (int[,])board.Clone();
			foreach(int re in region) {
				tmp[re / row, re % row] = check;
			}
			for(int i = 1; i < col - 1; i++) {
				for(int j = 1; j < row - 1; j++) {
					if(tmp[i, j] == 0) {
						if(dps(i * row + j) % cells != 0) {
							return false;
						}
					}
				}
			}
			return true;
		}
		private int dps(int point) {
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

		// Checkクラス同様,盤面の数字の置き換えを行う
		// 置き換える数字はブロックのマス毎に適した数字を用いる
		public void paint(int[] point, int[] nums) {
			for(int i = 0; i < point.Length; i++) {
				board[point[i] / row, point[i] % row] = nums[i];
			}
		}


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

		public int[] cross(int basePoint) {
			return new int[] { basePoint - row, basePoint - 1, basePoint + 1, basePoint + row };
		}

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
