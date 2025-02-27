using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4 {
	class Program {
		static bool CheckTPLZ(int[,] adj) {
			if (adj.Length == 0) {
				return false;
			}
			int n = Math.Min(adj.GetLength(0), adj.GetLength(1));
			for (int i = 0; i < n; i++) {
				if (adj[i, i] != adj[0, 0]) {
					return false;
				}
			}
			return true;
		}	
		static void Main(string[] args) {
			int[,] adj = {{1, 2, 3, 4},{5, 1, 2, 3},{9, 5, 1, 2}};
			bool res = CheckTPLZ(adj);
			Console.WriteLine(res ? "It's a TPLZ" : "It's not a TPLZ");
		}
	}
}
