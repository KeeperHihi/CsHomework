using System;
using System.Collections.Generic;
using System.Linq;

namespace task3 {
	class Program {
		static List<int> FindPrimes(int n) {
			bool[] vis = new bool[n + 1];
			List<int> primes = new List<int>();
			for (int i = 2; i <= n; i++) {
				if (vis[i] == true) {
					continue;
				}
				primes.Add(i);
				for (int j = 2; j * i <= n; j++) {
					vis[j * i] = true;
				}
			}
			return primes;
		}
		static void Main(string[] args) {
			int n;
			bool res = int.TryParse(Console.ReadLine(), out n);
			if (res == false) {
				Console.WriteLine("Invalid Input");
				return;
			}
			var primes = FindPrimes(n);
			Console.WriteLine(string.Join(" ", primes));
		}
	}
}
