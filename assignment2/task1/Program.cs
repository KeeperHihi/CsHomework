using System;
using System.Collections.Generic;

namespace Task1 {
	class Program {
		static List<int> FindPrimeFactors(int n) {
			List<int> ans = new List<int>();
			for (int i = 2; i * i <= n; i++) {
				if (n % i == 0) {
					ans.Add(i);
					while (n % i == 0) {
						n /= i;
					}
				}
			}
			if (n != 1) {
				ans.Add(n);
			}
			return ans;
		}
		static void Main(string[] args) {
			int n;
			bool res = int.TryParse(Console.ReadLine(), out n);
			if (res == false) {
				Console.WriteLine("Error Input");
				return;
			}
			var pfactors = FindPrimeFactors(n);	
			Console.WriteLine(string.Join(" ", pfactors));
		}
	}
}
