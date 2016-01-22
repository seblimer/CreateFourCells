using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFourCells {
	class Guess {
		Guess parent = null;
		int[,] board;
		bool check = false;
		Queue<Guess> guess = new Queue<Guess>();

		public Guess(int[,] board) {
			this.board = board;
		}

		public void entryChild(Guess child) {
			guess.Enqueue(child);
			child.entryParent(this);
		}
		private void entryParent(Guess parent) {
			this.parent = parent;
		}

		/***************************************
		 * 次の推測にとぶ
		 * この要素になければ親のnextを呼ぶ
		 **************************************/
		public Guess next() {
			if(guess.Count > 0) {
				return guess.Dequeue();
			}
			if(parent != null) {
				return parent.next();
			}
			return null;
		}

		public bool Check {
			get { return check; }
			set { check = value; }
		}

		public int[,] getBoard() {
			return board;
		}
	}
}
